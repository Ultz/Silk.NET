// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Native;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch
{
    public interface IMarshalContext
    {
        /// <summary>
        /// The Compilation this method originated from
        /// </summary>
        Compilation Compilation { get; }

        /// <summary>
        /// Indicates the method slot
        /// </summary>
        int Slot { get; }

        /// <summary>
        /// All Load types in order, last is the return type
        /// </summary>
        ITypeSymbol[] LoadTypes { get; }

        /// <summary>
        /// The type loaded as return type from native
        /// </summary>
        ref ITypeSymbol ReturnLoadType { get; }

        /// <summary>
        /// Indicates whether the parameter at each index should be pinned before sent to native
        /// </summary>
        bool[] ShouldPinParameter { get; }

        /// <summary>
        /// The source method symbol
        /// </summary>
        IMethodSymbol MethodSymbol { get; }

        /// <summary>
        /// Indicates whether the source method returns void (and therefore whether there is a Result Expression)
        /// </summary>
        bool ReturnsVoid { get; }

        /// <summary>
        /// The Variable id used to access the result
        /// </summary>
        int? ResultVariable { get; set; }

        /// <summary>
        /// The current type of the <see cref="ResultVariable"/>
        /// </summary>
        ITypeSymbol? CurrentResultType { get; set; }

        /// <summary>
        /// Parameter Marshal pptions
        /// </summary>
        MarshalOptions?[] ParameterMarshalOptions { get; }

        /// <summary>
        /// Return Marshal options
        /// </summary>
        MarshalOptions? ReturnMarshalOptions { get; }

        /// <summary>
        /// The Variable IDs assigned to each parameter
        /// </summary>
        int[] ParameterVariables { get; }

        /// <summary>
        /// The stage currently at.
        /// </summary>
        SilkTouchStage CurrentStage { get; }

        /// <summary>
        /// Declare a variable
        /// </summary>
        /// <param name="type">the type of this variable</param>
        /// <param name="allowInlining">Can this variable be inlined</param>
        /// <returns>the variable ID</returns>
        int DeclareVariable(ITypeSymbol type, bool allowInlining = true);

        /// <summary>
        /// Set a variable
        /// </summary>
        /// <param name="id">the id <see cref="DeclareVariable"/></param>
        /// <param name="expressionFunc">the expression to set the variable to</param>
        void SetVariable(int id, Func<IMarshalContext, ExpressionSyntax> expressionFunc);

        /// <summary>
        /// Set Parameter to variable
        /// </summary>
        /// <param name="parameter">The parameter index</param>
        /// <param name="variable">The variable id</param>
        void SetParameterToVariable(int parameter, int variable);

        /// <summary>
        /// Resolve variable
        /// </summary>
        /// <param name="id">The variable id</param>
        /// <param name="ignoreRef">Setting this to true will ignore the reference</param>
        /// <returns>Expression used to access the value</returns>
        Lazy<ExpressionSyntax> ResolveVariable(int id, bool ignoreRef = false);

        /// <summary>
        /// Allocate a GC Slot
        /// </summary>
        int AllocateGcSlot();

        void BeginBlock(Func<StatementSyntax, IMarshalContext, StatementSyntax> applyBlock);

        /// <summary>
        /// Declare a special variable that cannot be processed by the context.
        /// </summary>
        /// <remarks>These special variables will never be inlined</remarks>
        /// <param name="symbol">The type of the variable</param>
        /// <param name="declare">Should the context pre-declare this variable</param>
        /// <returns>A touple of ID and string that can be used to access and assign the special variable</returns>
        (int, string) DeclareSpecialVariableNoInlining(ITypeSymbol symbol, bool declare);

        IEnumerable<Lazy<ExpressionSyntax>> ResolveAllLoadParameters();

        void AddSideEffect(Func<IMarshalContext, StatementSyntax> expression);

        /// <summary>
        /// Adds a side effect at a specific stage.
        /// </summary>
        /// <param name="silkTouchStage">The stage to add to.</param>
        /// <param name="expression">The expression that is called when transitioning. The given context will be the context pre-transition.</param>
        void AddSideEffectToStage(SilkTouchStage silkTouchStage, Func<IMarshalContext, StatementSyntax> expression);
        
        void DeclareExtraRef(int id, int amount = 1);
        
        bool TryGetAttribute(int index, string typeFullName, out AttributeData? attributeData);

        bool TryGetAttribute(int index, Type type, out AttributeData? attributeData);

        bool TryGetAttribute<T>(int index, out AttributeData? attributeData) where T : Attribute;

        void TransitionTo(SilkTouchStage stage);
    }

    public class MarshalOptions
    {
        public MarshalOptions(UnmanagedType unmanagedType)
        {
            UnmanagedType = unmanagedType;
        }

        public UnmanagedType UnmanagedType { get; }
    }

    public class MarshalContext : IMarshalContext
    {
        /// <inheritdoc />
        public Compilation Compilation { get; }

        /// <inheritdoc />
        public int Slot { get; }

        /// <inheritdoc />
        public ITypeSymbol[] LoadTypes { get; }

        /// <inheritdoc />
        public ref ITypeSymbol ReturnLoadType => ref LoadTypes[LoadTypes.Length - 1];

        /// <inheritdoc />
        public bool[] ShouldPinParameter { get; }

        /// <inheritdoc />
        public IMethodSymbol MethodSymbol { get; }

        /// <inheritdoc />
        public bool ReturnsVoid => MethodSymbol.ReturnsVoid;

        /// <inheritdoc />
        public int? ResultVariable { get; set; }

        /// <inheritdoc />
        public ITypeSymbol? CurrentResultType { get; set; }

        /// <inheritdoc />
        public MarshalOptions?[] ParameterMarshalOptions { get; }

        /// <inheritdoc />
        public MarshalOptions? ReturnMarshalOptions { get; }

        /// <inheritdoc />
        public int[] ParameterVariables { get; }

        public int GCCount { get; private set; } = 0;

        /// <inheritdoc />
        public SilkTouchStage CurrentStage { get; private set; }

        private readonly List<Variable> _variables = new();
        private readonly List<StatementSyntax> _statements = new();
        private readonly Stack<(int Count, Func<StatementSyntax, IMarshalContext, StatementSyntax> applyBlock)> _blocks = new(); // _blocks contains the start of current blocks + how to apply the block
        private readonly Dictionary<SilkTouchStage, List<Func<IMarshalContext, StatementSyntax>>> _toInject = new();
        
        private class Variable
        {
            public ITypeSymbol Type { get; }
            public Func<IMarshalContext, ExpressionSyntax>? LatestValue { get; set; }
            public int ReadCount { get; set; }
            public List<Lazy<ExpressionSyntax>> RelatedLazies { get; } = new List<Lazy<ExpressionSyntax>>();
            public bool ForceInline { get; set; } = false;
            public bool AllowInline { get; set; } = true;
            public ExpressionSyntax? AccessExpression { get; set; }
            public bool IsResolving { get; set; }
            public bool Declare { get; set; } = true;

            public Variable(ITypeSymbol type)
            {
                Type = type;
            }
        }

        /// <inheritdoc />
        public int DeclareVariable(ITypeSymbol type, bool allowInlining = true)
        {
            _variables.Add
            (
                new Variable(type)
                {
                    AllowInline = allowInlining
                }
            );
            return _variables.Count - 1;
        }

        /// <inheritdoc />
        public void SetVariable(int id, Func<IMarshalContext, ExpressionSyntax> expressionFunc)
        {
            if (_variables[id].LatestValue is not null && _variables[id].ReadCount != 0)
            {
                // this happens when setting a value that has been previously set AND someone is interested
                foreach (var l in _variables[id].RelatedLazies)
                {
                    if (!l.IsValueCreated)
                        _ = l.Value; // ensure value created
                }
            }

            _variables[id].ReadCount = 0;
            _variables[id].RelatedLazies.Clear();
            _variables[id].LatestValue = expressionFunc;
            _variables[id].AccessExpression = null;
        }

        /// <inheritdoc />
        public void SetParameterToVariable(int parameter, int variable)
        {
            LoadTypes[parameter] = _variables[variable].Type;
            ParameterVariables[parameter] = variable;
        }

        public int AllocateGcSlot() => GCCount++;

        public void BeginBlock(Func<StatementSyntax, IMarshalContext, StatementSyntax> applyBlock)
        {
            _blocks.Push((_statements.Count, applyBlock));
        }

        private void EndBlock(int start, Func<StatementSyntax, IMarshalContext, StatementSyntax> block)
        {
            var end = _statements.Count;
            var length = end - start;

            StatementSyntax arg;

            switch (length)
            {
                case 0:
                    arg = EmptyStatement();
                    break;
                case 1:
                    arg = _statements[end - 1];
                    _statements.RemoveAt(end - 1);
                    break;
                default:
                {
                    var elements = _statements.GetRange(start, length);
                    _statements.RemoveRange(start, length);
                    arg = Block(elements);
                    break;
                }
            }

            _statements.Add(block(arg, this));
        }

        [Conditional("DEBUG")]
        public void AppendTrivia(SyntaxTrivia trivia)
        {
            if (_statements.Count == 0)
                _statements.Add(EmptyStatement());

            _statements[_statements.Count - 1] = _statements[_statements.Count - 1]
                .WithTrailingTrivia(_statements[_statements.Count - 1].GetTrailingTrivia().Append(trivia));
        }

        public (int, string) DeclareSpecialVariableNoInlining(ITypeSymbol symbol, bool declare)
        {
            var v = new Variable(symbol);
            var id = _variables.Count;
            var name = $"SPECIAL_VAR{id}";
            v.AccessExpression = ParenthesizedExpression(IdentifierName(name));
            v.Declare = declare;
            _variables.Add(v);
            return (id, name);
        }

        /// <inheritdoc />
        public Lazy<ExpressionSyntax> ResolveVariable(int id, bool ignoreRef = false)
        {
            if (!ignoreRef)
                _variables[id].ReadCount++;
            var l = new Lazy<ExpressionSyntax>(() => ResolveVariableFinal(id));
            _variables[id].RelatedLazies.Add(l);
            return l;
        }

        private ExpressionSyntax ResolveVariableFinal(int id)
        {
            if (_variables[id].AccessExpression is not null)
            {
                AppendTrivia
                (
                    SyntaxTrivia
                    (
                        SyntaxKind.SingleLineCommentTrivia,
                        $"// ALREADY RESOLVED {id}"
                    )
                );
                return _variables[id].AccessExpression;
            }

            AppendTrivia
            (
                SyntaxTrivia
                (
                    SyntaxKind.SingleLineCommentTrivia,
                    $"// BEGIN RESOLVE {id} | READCOUNT: {_variables[id].ReadCount} | ALLOW_INLINE: {_variables[id].AllowInline} | FORCE_INLINE: {_variables[id].ForceInline} | CACHED: {!(_variables[id].AccessExpression is null)}"
                )
            );
            if (_variables[id].IsResolving)
                throw new Exception($"Variable {id} is already resolving. This indicates a recursive variable dependency");

            _variables[id].IsResolving = true;

            var value = _variables[id].LatestValue(this);
            
            if ((_variables[id].ReadCount > 1 && !_variables[id].ForceInline) || !_variables[id].AllowInline)
            {
                // declare a variable & assign it
                var name = $"n{id}";
                AppendTrivia(SyntaxTrivia(SyntaxKind.SingleLineCommentTrivia, $"// RESOLVED {id} TO VARIABLE {name}"));
                var identifier = IdentifierName(name);

                if (_variables[id].Declare)
                    _statements.Insert(0, LocalDeclarationStatement(VariableDeclaration(IdentifierName(_variables[id].Type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)), SingletonSeparatedList(
                        VariableDeclarator(name)))));
                
                _statements.Add
                (
                    ExpressionStatement(AssignmentExpression(SyntaxKind.SimpleAssignmentExpression, identifier, value))
                );
                _variables[id].AccessExpression = identifier;
            }
            else
            {
                // do not declare a variable. inline.
                AppendTrivia(SyntaxTrivia(SyntaxKind.SingleLineCommentTrivia, $"// RESOLVED {id} INLINED"));
                _variables[id].AccessExpression = value;
            }
            
#if DEBUG
            _variables[id].AccessExpression = _variables[id]
                .AccessExpression!.WithLeadingTrivia
                (
                    _variables[id]
                        .AccessExpression.GetLeadingTrivia()
                        .Append(SyntaxTrivia(SyntaxKind.MultiLineCommentTrivia, $"/* VAR {id} */"))
                );
#endif
            
            _variables[id].IsResolving = false;
            AppendTrivia(SyntaxTrivia(SyntaxKind.SingleLineCommentTrivia, $"// END RESOLVE {id}"));
            return ParenthesizedExpression(_variables[id].AccessExpression);
        }

        public IEnumerable<Lazy<ExpressionSyntax>> ResolveAllLoadParameters()
        {
            return ParameterVariables.Select(x => ResolveVariable(x));
        }

        public void AddSideEffect(Func<IMarshalContext, StatementSyntax> expression)
        {
            _statements.Add(expression(this));
        }

        /// <inheritdoc />
        public void AddSideEffectToStage(SilkTouchStage silkTouchStage, Func<IMarshalContext, StatementSyntax> expression)
        {
            if (_toInject.TryGetValue(silkTouchStage, out var list))
                list.Add(expression);
            else
            {
                list = new List<Func<IMarshalContext, StatementSyntax>>();
                list.Add(expression);
                _toInject[silkTouchStage] = list;
            }
        }

        /// <inheritdoc />
        public void DeclareExtraRef(int id, int amount = 1)
        {
            _variables[id].ReadCount += amount;
        }

        public BlockSyntax BuildFinalBlock()
        {
            // add return
            if (!ReturnsVoid)
            {
                if (!ResultVariable.HasValue)
                    throw new InvalidOperationException($"Cannot build final block when function does not return void until {nameof(ResultVariable)} is assigned");

                var expr = ResolveVariable(ResultVariable.Value).Value;
                
                _statements.Add(ReturnStatement(expr));
            }

            // apply blocks
            while (_blocks.Count > 0)
            {
                var (start, func) = _blocks.Pop();
                EndBlock(start, func);
            }

            return Block(_statements);
        }

        /// <inheritdoc />
        public bool TryGetAttribute(int index, string typeFullName, out AttributeData? attributeData)
        {
            var attributes = 
                index > MethodSymbol.Parameters.Length - 1 
                    ? MethodSymbol.GetReturnTypeAttributes() 
                    : MethodSymbol.Parameters[index].GetAttributes();

            attributeData = attributes.FirstOrDefault
            (
                x => SymbolEqualityComparer.Default.Equals
                    (x.AttributeClass, Compilation.GetTypeByMetadataName(typeFullName))
            );

            return !(attributeData is null);
        }

        /// <inheritdoc />
        public bool TryGetAttribute
            (int index, Type type, out AttributeData? attributeData)
            => TryGetAttribute(index, type.FullName, out attributeData);

        /// <inheritdoc />
        public bool TryGetAttribute<T>
            (int index, out AttributeData? attributeData) where T : Attribute
            => TryGetAttribute(index, typeof(T), out attributeData);

        /// <inheritdoc />
        public void TransitionTo(SilkTouchStage stage)
        {
            if (stage < CurrentStage)
            {
                throw new ArgumentException("Cannot transition backwards");
            }

            if (_toInject.TryGetValue(stage, out var toInject))
            {
                foreach (var x in toInject)
                {
                    AddSideEffect(x);
                }
            }
            
            CurrentStage = stage;
        }

        public MarshalContext(Compilation compilation, IMethodSymbol methodSymbol, int slot)
        {
            Compilation = compilation;
            MethodSymbol = methodSymbol;
            Slot = slot;
            ParameterVariables = new int[MethodSymbol.Parameters.Length];

            LoadTypes = MethodSymbol.Parameters.Select
                    (x => x.Type)
                .Append
                (
                    MethodSymbol.ReturnsVoid
                        ? Compilation.GetSpecialType(SpecialType.System_Void)
                        : MethodSymbol.ReturnType
                )
                .ToArray();
            ShouldPinParameter = MethodSymbol.Parameters.Select(x => x.RefKind != RefKind.None).ToArray();

            MarshalOptions? GetOptions(ImmutableArray<AttributeData> attributes)
            {
                var unmanagedType = attributes
                    .FirstOrDefault
                    (
                        x => SymbolEqualityComparer.Default.Equals
                        (
                            x.AttributeClass,
                            Compilation.GetTypeByMetadataName
                                ("Silk.NET.Core.Attributes.UnmanagedTypeAttribute")
                        )
                    );

                if (unmanagedType is not null && unmanagedType.ConstructorArguments.Length > 0 && unmanagedType.ConstructorArguments[0].Value is not null)
                {
                    return new MarshalOptions((UnmanagedType) unmanagedType.ConstructorArguments[0].Value);
                }
                        
                var marshalAs = attributes
                    .FirstOrDefault
                    (
                        x => SymbolEqualityComparer.Default.Equals
                        (
                            x.AttributeClass,
                            Compilation.GetTypeByMetadataName
                                ("System.Runtime.InteropServices.MarshalAsAttribute")
                        )
                    );
                return marshalAs is null || marshalAs.ConstructorArguments.Length < 1 || marshalAs.ConstructorArguments[0].Value is null ? null : new MarshalOptions((UnmanagedType)(int)(System.Runtime.InteropServices.UnmanagedType) marshalAs.ConstructorArguments[0].Value);
            }
            
            ParameterMarshalOptions = methodSymbol.Parameters.Select
                (
                    x =>
                    {
                        return GetOptions(x.GetAttributes());
                    }
                )
                .ToArray();

            ReturnMarshalOptions = GetOptions(methodSymbol.GetReturnTypeAttributes());
        }
    }
}
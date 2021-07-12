// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using JetBrains.Application;
using JetBrains.Application.Progress;
using JetBrains.DocumentModel;
using JetBrains.Lifetimes;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Feature.Services.Daemon;
using JetBrains.ReSharper.Feature.Services.LinqTools;
using JetBrains.ReSharper.Feature.Services.QuickFixes;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.CSharp;
using JetBrains.ReSharper.Psi.CSharp.Tree;
using JetBrains.ReSharper.Psi.CSharp.Util;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.ReSharper.Psi.Util;
using JetBrains.TextControl;
using JetBrains.Util;

namespace ReSharperPlugin.SilkDotNet
{
    [ElementProblemAnalyzer
    (
        typeof(IUnsafeCodeFixedStatement),
        HighlightingTypes = new[] {typeof(UnnecessaryExplicitPinningHighlighting)}
    )]
    public class UnnecessaryExplicitPinningProblemAnalyzer : ElementProblemAnalyzer<IUnsafeCodeFixedStatement>
    {
        protected override void Run
            (IUnsafeCodeFixedStatement element, ElementProblemAnalyzerData data, IHighlightingConsumer consumer)
        {
            var block = element.Body as IBlock;
            if (element.PointerDeclarations.Count != 1 ||
                block?.Statements.Count != 1)
                return;

            var pointerDeclaration = element.PointerDeclarationsEnumerable.First();
            var pointerType = pointerDeclaration.Type;
            if (!pointerType.IsPointerType() ||
                !pointerType.GetScalarType().IsInt())
                return;

            IInvocationExpression invocationExpression;
            if (block.Statements.SingleItem is IExpressionStatement expressionStatement)
            {
                switch (expressionStatement.Expression)
                {
                    case IInvocationExpression e:
                        invocationExpression = e;
                        break;
                    case IAssignmentExpression {Source: IInvocationExpression e}:
                        invocationExpression = e;
                        break;
                    default:
                        return;
                }
            }
            else
            {
                return;
            }
            
            if (invocationExpression.Reference.Resolve().DeclaredElement is not IMethod method)
                return;

            var pointerArgument = default(ICSharpArgument);
            foreach (var argument in invocationExpression.Arguments)
            {
                var referenceExpression =
                    (argument.Expression as ICSharpExpression).GetOperandThroughParenthesis() as IReferenceExpression;
                if (referenceExpression?.Reference.Resolve()
                    .DeclaredElement?.Equals(pointerDeclaration.DeclaredElement) ?? false)
                {
                    pointerArgument = argument;
                    break;
                }
            }

            if (pointerArgument == null)
                return;

            var pointerArgumentIndex = method.Parameters.IndexOf(pointerArgument.MatchingParameter?.Element);
            var candidateMethods = method.ContainingType?.GetMembers().OfType<IMethod>()
                .Where(x => x.ShortName == method.ShortName)
                .Where(x => x.Parameters.Count == method.Parameters.Count)
                .Where(x => x.ReturnType.Equals(method.ReturnType))
                .Where
                (
                    x =>
                    {
                        var newParameters = x.Parameters.Select(x => x.Type).ToList();
                        var originalParameters = method.Parameters.Select(x => x.Type).ToList();

                        newParameters.RemoveAt(pointerArgumentIndex);
                        originalParameters.RemoveAt(pointerArgumentIndex);

                        return newParameters.SequenceEqual(originalParameters);
                    }
                )
                .Where(x => !x.Equals(method))
                .ToList();

            if (candidateMethods?.Count != 1)
                return;

            consumer.AddHighlighting
            (
                new UnnecessaryExplicitPinningHighlighting(element, invocationExpression, pointerArgument, candidateMethods.SingleItem(), block.Statements.SingleItem)
            );
        }
    }

    [RegisterConfigurableSeverity
    (
        SeverityId,
        CompoundItemName: null,
        Group: HighlightingGroupIds.CodeSmell,
        Title: Message,
        Description: Description,
        DefaultSeverity: Severity.WARNING
    )]
    [ConfigurableSeverityHighlighting
    (
        SeverityId,
        CSharpLanguage.Name,
        OverlapResolve = OverlapResolveKind.ERROR,
        OverloadResolvePriority = 0,
        ToolTipFormatString = Message
    )]
    public class UnnecessaryExplicitPinningHighlighting : IHighlighting
    {
        public const string SeverityId = nameof(UnnecessaryExplicitPinningHighlighting);
        public const string Message = "Unnecessary explicit pinning";
        public const string Description = "Unnecessary explicit pinning";

        public UnnecessaryExplicitPinningHighlighting
        (
            IUnsafeCodeFixedStatement fixedStatement,
            IInvocationExpression invocationExpression,
            ICSharpArgument pointerArgument,
            IMethod replacementMethod,
            IStatement originalStatement
        )
        {
            FixedStatement = fixedStatement;
            InvocationExpression = invocationExpression;
            PointerArgument = pointerArgument;
            ReplacementMethod = replacementMethod;
            OriginalStatement = originalStatement;
        }

        public IUnsafeCodeFixedStatement FixedStatement { get; }
        public IInvocationExpression InvocationExpression { get; }
        public ICSharpArgument PointerArgument { get; }
        public IMethod ReplacementMethod { get; }
        public IStatement OriginalStatement { get; }

        public bool IsValid()
        {
            return FixedStatement.IsValid();
        }

        public DocumentRange CalculateRange()
        {
            return FixedStatement.FixedKeyword.GetDocumentRange().JoinRight(FixedStatement.RPar.GetDocumentRange());
        }

        public string ToolTip => Message;

        public string ErrorStripeToolTip => Message;
    }

    public class UnnecessaryExplicitPinningFix : QuickFixBase
    {
        public UnnecessaryExplicitPinningFix(UnnecessaryExplicitPinningHighlighting warning)
        {
            FixedStatement = warning.FixedStatement;
            InvocationExpression = warning.InvocationExpression;
            PointerArgument = warning.PointerArgument;
            ReplacementMethod = warning.ReplacementMethod;
            OriginalStatement = warning.OriginalStatement;
        }

        public IUnsafeCodeFixedStatement FixedStatement { get; set; }
        public IInvocationExpression InvocationExpression { get; set; }
        public ICSharpArgument PointerArgument { get; set; }
        public IMethod ReplacementMethod { get; set; }
        public IStatement OriginalStatement { get; set; }

        public override string Text => $"Use appropriate overload";
    
        public override bool IsAvailable(IUserDataHolder cache)
        {
            return FixedStatement.IsValid();
        }
    
        protected override Action<ITextControl> ExecutePsiTransaction(ISolution solution, IProgressIndicator progress)
        {
            var elementFactory = CSharpElementFactory.GetInstance(FixedStatement);
            var data = (IExpressionInitializer) FixedStatement.PointerDeclarationsEnumerable.First().Initializer;
            var dataExpressions = elementFactory.CreateArgument
                (ParameterKind.VALUE, elementFactory.CreateExpression("$0", data.Value));
            PointerArgument.Expression.ReplaceBy(dataExpressions.Expression);
            PointerArgument.SetKind(ParameterKind.VALUE);
            InvocationExpression.Reference.BindTo(ReplacementMethod);
            FixedStatement.ReplaceBy(OriginalStatement);

            return null;
        }
    }
    
    [ShellComponent]
    internal class QuickFixRegistrar
    {
        public QuickFixRegistrar(IQuickFixes table)
        {
            table.RegisterQuickFix<UnnecessaryExplicitPinningHighlighting>(Lifetime.Eternal, h => new UnnecessaryExplicitPinningFix(h), typeof(UnnecessaryExplicitPinningFix));
        }
    }
}

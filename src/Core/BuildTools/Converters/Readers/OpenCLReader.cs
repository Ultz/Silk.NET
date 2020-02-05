// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis.CSharp;
using MoreLinq.Extensions;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Enums;
using Silk.NET.BuildTools.Common.Functions;
using Silk.NET.BuildTools.Converters.Khronos;
using Attribute = Silk.NET.BuildTools.Common.Attribute;
using Enum = Silk.NET.BuildTools.Common.Enums.Enum;
using Type = Silk.NET.BuildTools.Common.Functions.Type;

namespace Silk.NET.BuildTools.Converters.Readers
{
    public class OpenCLReader : IReader
    {
        private static readonly string[] Apis = "opencl".Split('|');

        private static readonly Dictionary<string, object> Constants = new Dictionary<string, object>
        {
            // Constants
            {"CL_CHAR_BIT", 8},
            {"CL_SCHAR_MAX", 127},
            {"CL_SCHAR_MIN", -127 - 1},
            {"CL_CHAR_MAX", 127},
            {"CL_CHAR_MIN", -127 - 1},
            {"CL_UCHAR_MAX", 255},
            {"CL_SHRT_MAX", 32767},
            {"CL_SHRT_MIN", -32767 - 1},
            {"CL_USHRT_MAX", 65535},
            {"CL_INT_MAX", 2147483647},
            {"CL_INT_MIN", -2147483647 - 1},
            {"CL_UINT_MAX", 0xffffffffU},
            {"CL_LONG_MAX", (long) 0x7FFFFFFFFFFFFFFFL},
            {"CL_LONG_MIN", (long) -0x7FFFFFFFFFFFFFFFL - 1L},
            {"CL_ULONG_MAX", (ulong) 0xFFFFFFFFFFFFFFFFUL},
            {"CL_FLT_DIG", 6},
            {"CL_FLT_MANT_DIG", 24},
            {"CL_FLT_MAX_10_EXP", +38},
            {"CL_FLT_MAX_EXP", +128},
            {"CL_FLT_MIN_10_EXP", -37},
            {"CL_FLT_MIN_EXP", -125},
            {"CL_FLT_RADIX", 2},
            {"CL_FLT_MAX", 340282346638528859811704183484516925440.0f},
            {"CL_FLT_MIN", 1.175494350822287507969e-38f},
            {"CL_FLT_EPSILON", 1.1920928955078125e-7f},
            {"CL_HALF_DIG", 3},
            {"CL_HALF_MANT_DIG", 11},
            {"CL_HALF_MAX_10_EXP", +4},
            {"CL_HALF_MAX_EXP", +16},
            {"CL_HALF_MIN_10_EXP", -4},
            {"CL_HALF_MIN_EXP", -13},
            {"CL_HALF_RADIX", 2},
            {"CL_HALF_MAX", 65504.0f},
            {"CL_HALF_MIN", 6.103515625e-05f},
            {"CL_HALF_EPSILON", 9.765625e-04f},
            {"CL_DBL_DIG", 15},
            {"CL_DBL_MANT_DIG", 53},
            {"CL_DBL_MAX_10_EXP", +308},
            {"CL_DBL_MAX_EXP", +1024},
            {"CL_DBL_MIN_10_EXP", -307},
            {"CL_DBL_MIN_EXP", -1021},
            {"CL_DBL_RADIX", 2},
            {"CL_DBL_MAX", 1.7976931348623158e+308},
            {"CL_DBL_MIN", 2.225073858507201383090e-308},
            {"CL_DBL_EPSILON", 2.220446049250313080847e-16},
            {"CL_M_E", 2.7182818284590452354},
            {"CL_M_LOG2E", 1.4426950408889634074},
            {"CL_M_LOG10E", 0.43429448190325182765},
            {"CL_M_LN2", 0.69314718055994530942},
            {"CL_M_LN10", 2.30258509299404568402},
            {"CL_M_PI", 3.14159265358979323846},
            {"CL_M_PI_2", 1.57079632679489661923},
            {"CL_M_PI_4", 0.78539816339744830962},
            {"CL_M_1_PI", 0.31830988618379067154},
            {"CL_M_2_PI", 0.63661977236758134308},
            {"CL_M_2_SQRTPI", 1.12837916709551257390},
            {"CL_M_SQRT2", 1.41421356237309504880},
            {"CL_M_SQRT1_2", 0.70710678118654752440},
            {"CL_M_E_F", 2.718281828f},
            {"CL_M_LOG2E_F", 1.442695041f},
            {"CL_M_LOG10E_F", 0.434294482f},
            {"CL_M_LN2_F", 0.693147181f},
            {"CL_M_LN10_F", 2.302585093f},
            {"CL_M_PI_F", 3.141592654f},
            {"CL_M_PI_2_F", 1.570796327f},
            {"CL_M_PI_4_F", 0.785398163f},
            {"CL_M_1_PI_F", 0.318309886f},
            {"CL_M_2_PI_F", 0.636619772f},
            {"CL_M_2_SQRTPI_F", 1.128379167f},
            {"CL_M_SQRT2_F", 1.414213562f},
            {"CL_M_SQRT1_2_F", 0.707106781f},
            {"CL_NAN", float.NaN},
            {"CL_HUGE_VALF", (float) 1e50},
            {"CL_HUGE_VAL", double.PositiveInfinity},
            {"CL_MAXFLOAT", float.MaxValue},
            {"CL_INFINITY", float.PositiveInfinity},
            
            // MiscNumbers
            {"CL_PROPERTIES_LIST_END_EXT", 0},
            {"CL_PARTITION_BY_COUNTS_LIST_END_EXT", 0},
            {"CL_DEVICE_PARTITION_BY_COUNTS_LIST_END", 0x0},
            {"CL_PARTITION_BY_NAMES_LIST_END_EXT", 0 - 1},
            {"CL_PARTITION_BY_NAMES_LIST_END_INTEL", -1},
        };
        public object Load(Stream stream)
        {
            return XDocument.Load(stream);
        }

        public IEnumerable<Struct> ReadStructs(object obj, ProfileConverterOptions opts)
        {
            return Enumerable.Empty<Struct>();
        }
        
        ////////////////////////////////////////////////////////////////////////////////////////
        // Function Parsing
        ////////////////////////////////////////////////////////////////////////////////////////

        public IEnumerable<Function> ReadFunctions(object obj, ProfileConverterOptions opts)
        {
            var doc = obj as XDocument;
            var allFunctions = doc.Element("registry").Elements("commands")
                .Elements("command")
                .Select(x => TranslateCommand(x, opts))
                .ToDictionary(x => x.Attribute("name")?.Value, x => x);
            var apis = doc.Element("registry").Elements("feature").Concat(doc.Element("registry").Elements("extensions").Elements("extension"));
            var removals = doc.Element("registry").Elements("feature")
                .Elements("remove")
                .Elements("command")
                .Attributes("name")
                .Select(x => x.Value)
                .ToList();
            foreach (var api in apis)
            {
                foreach (var requirement in api.Elements("require"))
                {
                    var apiName = requirement.Attribute("api")?.Value ??
                                  api.Attribute("api")?.Value ??
                                  api.Attribute("supported")?.Value ??
                                  "opencl";
                    var apiVersion = api.Attribute("number") != null
                        ? Version.Parse(api.Attribute("number").Value)
                        : null;
                    foreach (var name in apiName.Split('|'))
                    {
                        foreach (var function in requirement.Elements("command")
                            .Attributes("name")
                            .Select(x => x.Value))
                        {
                            var xf = allFunctions[TrimName(function, opts)];

                            var ret = new Function
                            {
                                Attributes = removals.Contains(function)
                                    ? new List<Attribute>
                                    {
                                        new Attribute
                                        {
                                            Name = "System.Obsolete",
                                            Arguments = new List<string>
                                            {
                                                $"\"Deprecated in version {apiVersion?.ToString(2)}\""
                                            }
                                        }
                                    }
                                    : new List<Attribute>(),
                                Categories = new List<string>{TrimName(api.Attribute("name")?.Value, opts)},
                                Doc = string.Empty,
                                ExtensionName = api.Name == "feature" ? "Core" : TrimName(api.Attribute("name")?.Value, opts),
                                GenericTypeParameters = new List<GenericTypeParameter>(),
                                Name = Naming.Translate(NameTrimmer.Trim(TrimName(xf.Attribute("name")?.Value, opts), opts.Prefix), opts.Prefix),
                                NativeName = function,
                                Parameters = ParseParameters(xf),
                                ProfileName = name,
                                ProfileVersion = apiVersion,
                                ReturnType = ParseTypeSignature(xf.Element("returns"))
                            };

                            yield return ret;

                            allFunctions.Remove(function);
                        }
                    }
                }
            }
        }
        
        [NotNull]
        public static Type ParseTypeSignature([NotNull] XElement typeElement)
        {
            var typeString = typeElement.Attribute("type")?.Value ?? throw new DataException("Couldn't find type.");
            var group = typeElement.Attribute("group")?.Value;

            var ret = ParseTypeSignature(typeString);

            if (!(group is null))
            {
                ret.OriginalGroup = group;
            }

            return ret;
        }
        
        [NotNull]
        public static Type ParseTypeSignature([NotNull] string type, string original = null)
        {
            if (type.Contains('*') && (type.Contains('[') || type.Contains(']')))
            {
                throw new InvalidDataException("A type cannot be both a pointer and an array at the same time.");
            }

            const string constValueSpecifier = "const ";
            const string constPointerSpecifier = " const";
            const string structSpecifier = "struct ";

            // We'll ignore struct and const specifiers for the moment
            var isConstValue = type.StartsWith(constValueSpecifier);
            if (isConstValue)
            {
                type = type.Remove(0, constValueSpecifier.Length);
            }

            var isConstPointer = type.EndsWith(constPointerSpecifier);
            if (isConstPointer)
            {
                var specifierIndex = type.LastIndexOf(constPointerSpecifier, StringComparison.Ordinal);
                type = type.Remove(specifierIndex);
            }

            var isStruct = type.StartsWith(structSpecifier);
            if (isStruct)
            {
                type = type.Remove(0, structSpecifier.Length);
            }

            var typeName = new string(type.ToCharArray().Where(c => !char.IsWhiteSpace(c)).ToArray());

            var pointerLevel = 0;
            var isPointer = type.EndsWith("*");
            if (isPointer)
            {
                var firstPointerLevelIndex = typeName.IndexOf('*');
                var lastPointerLevelIndex = typeName.LastIndexOf('*');

                pointerLevel = Math.Abs(lastPointerLevelIndex - firstPointerLevelIndex) + 1;

                typeName = typeName.Remove(firstPointerLevelIndex);
            }

            var arrayLevel = 0;
            var isArray = typeName.EndsWith("]");
            if (isArray)
            {
                var firstArrayIndex = typeName.IndexOf('[');
                var lastArrayIndex = typeName.IndexOf(']');

                arrayLevel = Math.Abs(firstArrayIndex - lastArrayIndex);

                typeName = typeName.Remove(firstArrayIndex);
            }

            return new Type
            {
                Name = typeName,
                OriginalName = original ?? typeName,
                IndirectionLevels = pointerLevel,
                ArrayDimensions = arrayLevel
            };
        }
        
        /// </returns>
        [CanBeNull]
        [ContractAnnotation
        (
            "hasComputedCount : true => computedCountParameterNames : notnull; hasValueReference : true => valueReferenceName : notnull"
        )]
        public static Count ParseCountSignature
        (
            [CanBeNull] string countData,
            out bool hasComputedCount,
            [CanBeNull] out IReadOnlyList<string> computedCountParameterNames,
            out bool hasValueReference,
            [CanBeNull] out string valueReferenceName,
            [CanBeNull] out string valueReferenceExpression
        )
        {
            computedCountParameterNames = null;
            valueReferenceName = null;
            valueReferenceExpression = null;

            hasComputedCount = false;
            hasValueReference = false;

            if (string.IsNullOrWhiteSpace(countData))
            {
                return null;
            }

            if (int.TryParse(countData, out var staticCount))
            {
                return new Count(staticCount);
            }

            var countDataSpan = countData.AsSpan();
            if (countDataSpan.StartsWith("COMPSIZE"))
            {
                var slice = countDataSpan.Slice(countDataSpan.IndexOf('(') + 1);
                slice = slice.Slice(0, slice.IndexOf(')'));

                var countList = new List<string>();
                var record = string.Empty;
                foreach (var character in slice)
                {
                    if (character == ',')
                    {
                        countList.Add(record.Trim());
                        record = string.Empty;
                        continue;
                    }

                    record += character;
                }

                if (!string.IsNullOrWhiteSpace(record))
                {
                    countList.Add(record.Trim());
                }

                return new Count(countList);
            }

            if (SyntaxFacts.IsValidIdentifier(countData))
            {
                // It's a parameter value reference count (that is, taken from the value of another parameter)
                valueReferenceName = countData;

                hasValueReference = true;
                return new Count(valueReferenceName);
            }

            static bool IsMath(ReadOnlySpan<char> span)
            {
                for (int i = 0; i < span.Length; i++)
                {
                    if (span[i] != '+'
                        && span[i] != '-'
                        && span[i] != '*'
                        && span[i] != '/'
                        && span[i] != '^'
                        && span[i] != ' '
                        && !char.IsDigit(span[i]))
                    {
                        return false;
                    }
                }

                return true;
            }

            // check for count with expression.
            if (char.IsLetter(countDataSpan[0]))
            {
                int i = 1;
                while (char.IsLetterOrDigit(countDataSpan[i]))
                {
                    i++;
                } // at this point there HAS to be some invalid letter there, so no for needed.

                var identifier = new string(countDataSpan.Slice(0, i));
                var expression = countDataSpan.Slice(i);

                if (SyntaxFacts.IsValidIdentifier(identifier) && IsMath(expression))
                {
                    // the rest is likely a mathematical expression
                    valueReferenceName = identifier;
                    valueReferenceExpression = new string(expression);

                    hasValueReference = true;
                    return new Count(valueReferenceName);
                }
            }
            
            throw new InvalidDataException("No valid count could be parsed from the input.");
        }
        
        private static List<Parameter> ParseParameters([NotNull] XElement functionElement)
        {
            var parameterElements = functionElement.Elements().Where(e => e.Name == "param");
            var parametersWithComputedCounts =
                new List<(Parameter Parameter, IReadOnlyList<string> ComputedCountParameterNames)>();
            var parametersWithValueReferenceCounts =
                new List<(Parameter Parameter, string ParameterReferenceName)>();

            var resultParameters = new List<Parameter>();

            foreach (var parameterElement in parameterElements)
            {
                var parameter = ParseParameter
                (
                    parameterElement,
                    out var hasComputedCount,
                    out var computedCountParameterNames,
                    out var hasValueReference,
                    out var valueReferenceName,
                    out _
                );

                if (hasComputedCount)
                {
                    parametersWithComputedCounts.Add((parameter, computedCountParameterNames));
                }

                if (hasValueReference)
                {
                    parametersWithValueReferenceCounts.Add((parameter, valueReferenceName));

                    // TODO: Pass on the mathematical expression
                }

                resultParameters.Add(parameter);
            }

            return resultParameters;
        }
        
        private static Parameter ParseParameter
        (
            [NotNull] XElement paramElement,
            out bool hasComputedCount,
            [CanBeNull] out IReadOnlyList<string> computedCountParameterNames,
            out bool hasValueReference,
            [CanBeNull] out string valueReferenceName,
            [CanBeNull] out string valueReferenceExpression
        )
        {
            var paramName = paramElement.Attribute("name")?.Value ?? throw new DataException("Missing name attribute.");

            // A parameter is technically a type signature (think of it as Parameter : ITypeSignature)
            var paramType = ParseTypeSignature(paramElement);

            var paramFlowStr = paramElement.Attribute("flow").Value ?? throw new DataException("Missing flow attribute.");

            if (!System.Enum.TryParse<FlowDirection>(paramFlowStr, true, out var paramFlow))
            {
                throw new InvalidDataException("Could not parse the parameter flow.");
            }

            var paramCountStr = paramElement.Attribute("count")?.Value;
            var countSignature = ParseCountSignature
            (
                paramCountStr,
                out hasComputedCount,
                out computedCountParameterNames,
                out hasValueReference,
                out valueReferenceName,
                out valueReferenceExpression
            );

            return new Parameter
            {
                Name = Utilities.CSharpKeywords.Contains(paramName) ? $"@{paramName}" : paramName,
                Flow = paramFlow,
                Type = paramType,
                Count = countSignature,
                Attributes = paramType.Name.StartsWith
                    ("CL_CALLBACK")
                    ? new List<Attribute>
                    {
                        new Attribute
                        {
                            Arguments = new List<string> {"Ultz.SuperInvoke.InteropServices.PinMode.UntilNextCall"},
                            Name = "Ultz.SuperInvoke.InteropServices.PinObjectAttribute"
                        }
                    }
                    : new List<Attribute>()
            };
        }

        private string FunctionName(XElement e, ProfileConverterOptions opts)
        {
            return TrimName(e.Element("proto")?.Element("name")?.Value, opts);
        }

        public string TrimName(string name, ProfileConverterOptions opts)
        {
            if (name.ToUpper().StartsWith($"{opts.Prefix.ToUpper()}_"))
            {
                return name.Remove(0, opts.Prefix.Length + 1);
            }

            return name.ToLower().StartsWith(opts.Prefix.ToLower()) ? name.Remove(0, opts.Prefix.Length) : name;
        }

        private static Random _random = new Random();
        private static string FunctionParameterType(XElement e)
        {
            // Parse the C-like <proto> element. Possible instances:
            // Return types:
            // - <proto>void <name>clGetSharpenTexFuncSGIS</name></proto>
            //   -> <returns>void</returns>
            // - <proto group="String">const <ptype>clubyte</ptype> *<name>clGetString</name></proto>
            //   -> <returns>String</returns>
            // Note: group attribute takes precedence if it exists. This matches the old .spec file format.
            // Parameter types:
            // - <param><ptype>clenum</ptype> <name>shadertype</name></param>
            //   -> <param name="shadertype" type="clenum" />
            // - <param len="1"><ptype>clsizei</ptype> *<name>length</name></param>
            //   -> <param name="length" type="clsizei" count="1" />
            var proto = e.Value;
            var name = e.Element("name");
            if (name == null) {
                Debug.WriteLine($"Warning: Parameter name is null. Element: {e}.");
            }

            var ret = name is null
                ? proto
                : proto.Remove(proto.LastIndexOf(name.Value, StringComparison.Ordinal)).Trim();

            return ret;
        }
        
        private XElement TranslateCommand(XElement command, ProfileConverterOptions opts)
        {
            var function = new XElement("function");

            var cmdName = FunctionName(command, opts);
            var name = new XAttribute("name", cmdName);

            var returns = new XElement
            (
                "returns",
                command.Element("proto").Attribute("group") is null ? new object[]{new XAttribute
                (
                    "type",
                    FunctionParameterType(command.Element("proto"))
                        .Replace("const", string.Empty)
                        .Replace("struct", string.Empty)
                        .Replace("String *", "String")
                        .Trim()
                )} : new object[]{new XAttribute
                (
                    "type",
                    FunctionParameterType(command.Element("proto"))
                        .Replace("const", string.Empty)
                        .Replace("struct", string.Empty)
                        .Replace("String *", "String")
                        .Trim()
                ), new XAttribute("group", command.Element("proto").Attribute("group").Value)}
            );

            foreach (var parameter in command.Elements("param"))
            {
                var param = FunctionParameterType(parameter);

                var p = new XElement("param");
                string randomName = null;
                if (parameter.Element("name") is null)
                {
                    Debug.WriteLine($"Warning: Parameter name is null. Element: {parameter}.");
                    randomName = "unnamedParameter" + GetRandomName();
                    Debug.WriteLine($"Giving it random name {randomName}");
                }
                
                var pname = new XAttribute("name", parameter.Element("name")?.Value ?? randomName);
                var type = new XAttribute
                (
                    "type",
                    param
                        .Replace("const", string.Empty)
                        .Replace("struct", string.Empty)
                        .Trim()
                );

                var count = parameter.Attribute("len") != null
                    ? new XAttribute("count", parameter.Attribute("len")?.Value ?? throw new NullReferenceException())
                    : null;

                var flow = new XAttribute
                (
                    "flow",
                    param.Contains("*") && !param.Contains("const") ? "out" : "in"
                );

                p.Add(pname, type, flow);
                if (count != null)
                {
                    p.Add(count);
                }

                if (!(parameter.Attribute("group") is null))
                {
                    p.Add(new XAttribute("group", parameter.Attribute("group").Value));
                }

                function.Add(p);
            }

            function.Add(name);
            function.Add(returns);
            return function;

            string GetRandomName()
            {
                var bytes = new byte[4];
                _random.NextBytes(bytes);
                return BitConverter.ToString(bytes).Replace("-", null);
            }
        }
        
        ////////////////////////////////////////////////////////////////////////////////////////
        // Enum Parsing
        ////////////////////////////////////////////////////////////////////////////////////////

        public IEnumerable<Enum> ReadEnums(object obj, ProfileConverterOptions opts)
        {
            var doc = obj as XDocument;
            var allEnums = doc.Element("registry")
                .Elements("enums")
                .Elements("enum")
                .DistinctBy(x => x.Attribute("name")?.Value)
                .Where
                (
                    x => x.Parent?.Attribute("name")?.Value != "Constants" &&
                         x.Parent?.Attribute("name")?.Value != "MiscNumbers"
                )
                .ToDictionary
                (
                    x => x.Attribute("name")?.Value,
                    x => FormatToken
                    (
                        x.Attribute("value")?.Value ?? (x.Attribute("bitpos") is null
                            ? null
                            : (1 << int.Parse(x.Attribute("bitpos").Value)).ToString())
                    )
                );
            var apis = doc.Element("registry").Elements("feature").Concat(doc.Element("registry").Elements("extensions").Elements("extension"));
            var removals = doc.Element("registry").Elements("feature")
                .Elements("remove")
                .Elements("enum")
                .Attributes("name")
                .Select(x => x.Value)
                .ToList();
            foreach (var api in apis)
            {
                foreach (var requirement in api.Elements("require"))
                {
                    var apiName = requirement.Attribute("api")?.Value ??
                                  api.Attribute("api")?.Value ??
                                  api.Attribute("supported")?.Value ??
                                  "opencl";
                    var apiVersion = api.Attribute("number") != null
                        ? Version.Parse(api.Attribute("number").Value)
                        : null;
                    var tokens = requirement.Elements("enum")
                        .Attributes("name")
                        .Where(x => !Constants.ContainsKey(x.Value) && allEnums.ContainsKey(x.Value))
                        .Select
                        (
                            token => new Token
                            {
                                Attributes = removals.Contains(token.Value)
                                    ? new List<Attribute>
                                    {
                                        new Attribute
                                        {
                                            Arguments = new List<string>
                                                {$"\"Deprecated in version {apiVersion?.ToString(2)}\""},
                                            Name = "System.Obsolete"
                                        }
                                    }
                                    : new List<Attribute>(),
                                Doc = string.Empty,
                                Name = Naming.Translate(TrimName(token.Value, opts), opts.Prefix),
                                NativeName = token.Value,
                                Value = allEnums.ContainsKey
                                    (token.Value)
                                    ? allEnums[token.Value]
                                    : FormatToken(Constants[token.Value].ToString())
                            }
                        )
                        .ToList();
                    foreach (var name in apiName.Split('|'))
                    {
                        var ret = new Enum
                        {
                            Attributes = new List<Attribute>(),
                            ExtensionName = api.Name == "feature"
                                ? "Core"
                                : TrimName(api.Attribute("name")?.Value, opts),
                            Name = Naming.Translate(TrimName(api.Attribute("name")?.Value, opts), opts.Prefix),
                            NativeName = api.Attribute("name")?.Value,
                            ProfileName = name,
                            ProfileVersion = apiVersion,
                            Tokens = tokens
                        };

                        yield return ret;
                    }
                }
            }
        }

        public IEnumerable<Constant> ReadConstants(object obj, ProfileConverterOptions opts)
        {
            return Constants.Select
            (
                x => new Constant
                {
                    Name = Naming.Translate(TrimName(x.Key, opts), opts.Prefix), NativeName = x.Key,
                    Type = GetType(x.Value), Value = x.Value.ToString()
                }
            );
        }

        private Type GetType(object o) => o switch
        {
            double _ => new Type {Name = "double"},
            float _ => new Type {Name = "float"},
            int _ => new Type {Name = "int"},
            long _ => new Type {Name = "long"},
            ulong _ => new Type {Name = "ulong"},
            _ => new Type {Name = "int"}
        };

        private static string FormatToken(string token)
        {
            if (token == null)
            {
                return null;
            }
            
            if (token == "CL_TRUE") return 1.ToString();
            if (token == "CL_FALSE") return 0.ToString();
            if (token == "(0x1 << 24)") return (0x1 << 24).ToString();
            if (token == "(0x2 << 24)") return (0x2 << 24).ToString();
            if (token == "(0x3 << 24)") return (0x3 << 24).ToString();
            if (token == "(0x55 << 24)") return (0x55 << 24).ToString();
            if (token == "(0xAA << 24)") return (0xAA << 24).ToString();
            if (token == "(0xFF << 24)") return (0xFF << 24).ToString();
            if (token == "(0x1 << 24)") return (0x1 << 24).ToString();
            if (token == "(0x2 << 24)") return (0x2 << 24).ToString();
            if (token == "(0x1 << 26)") return (0x1 << 26).ToString();
            if (token == "(0x2 << 26)") return (0x2 << 26).ToString();
            if (token == "(0x1 << 28)") return (0x1 << 28).ToString();
            if (token == "(0x2 << 28)") return (0x2 << 28).ToString();
            if (token == "(0x1 << 30)") return (0x1 << 30).ToString();
            if (token == "(0x2 << 30)") return (0x2 << 30).ToString();

            var tokenHex = token.StartsWith("0x") ? token.Substring(2) : token;

            if (!long.TryParse(tokenHex, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var value))
            {
                if (!long.TryParse(tokenHex, out value))
                {
                    if (!ulong.TryParse(tokenHex, out var uValue))
                    {
                        throw new InvalidDataException("Token value was not in a valid format.");
                    }

                    value = unchecked((long) uValue);
                }
            }

            var valueString = $"0x{value:X}";
            var needsCasting = value > int.MaxValue || value < 0;
            if (needsCasting)
            {
                Debug.WriteLine($"Warning: casting overflowing enum value {token} from 64-bit to 32-bit.");
                valueString = $"unchecked((int){valueString})";
            }

            return valueString;
        }
    }
}

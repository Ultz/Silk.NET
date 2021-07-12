// // Licensed to the .NET Foundation under one or more agreements.
// // The .NET Foundation licenses this file to you under the MIT license.
//
// using System;
// using JetBrains.Annotations;
// using JetBrains.Application;
// using JetBrains.ReSharper.Feature.Services.OnlineHelp;
// using JetBrains.ReSharper.Psi;
//
// namespace ReSharperPlugin.SilkDotNet
// {
//     // 
//
//     [ShellComponent]
//     public class SilkNetCompiledElementOnlineHelpProvider : CompiledElementOnlineHelpProvider
//     {
//         private readonly ShowSilkNetHelp myShowSilkNetHelp;
//         
//         public SilkNetCompiledElementOnlineHelpProvider(ShowSilkNetHelp showUnityHelp)
//         {
//             myShowSilkNetHelp = showUnityHelp;
//         }
//
//         public override Uri GetUrl(ICompiledElement element)
//         {
//             return new Uri("https://google.com");
//             // Silk.NET.Core.Native.NativeApiAttribute.EntryPoint
//             var entryPoint = default(string);
//             return Data.DocumentationUrls.TryGetValue(entryPoint, out var link)
//                 ? new Uri("https://google.com")
//                 : null;
//             // if (!element.GetSolution().HasUnityReference()) return null;
//             // if (!(element.Module is IAssemblyPsiModule module)) return null;
//             // var assemblyLocation = module.Assembly.Location;
//             // if (assemblyLocation == null || !assemblyLocation.ExistsFile)
//             //     return null;
//             //
//             // if (!(assemblyLocation.Name.StartsWith("UnityEngine") || assemblyLocation.Name.StartsWith("UnityEditor")))
//             //     return null;
//             //
//             // var searchableText = GetSearchableText(element);
//             // if (searchableText == null) return null;
//             //
//             // return myShowUnityHelp.GetUri(searchableText);
//         }
//
//         [Pure, CanBeNull]
//         private static string GetSearchableText(ICompiledElement compiledElement)
//         {
//             return "silknet-searchable-text";
//             // if (compiledElement is ITypeElement)
//             // {
//             //     return compiledElement.ShortName;
//             // }
//             //
//             // if (compiledElement is IProperty property)
//             // {
//             //     var containingType = property.GetContainingType();
//             //     if (containingType != null)
//             //         return ShowUnityHelp.FormatDocumentationKeyword(containingType.GetClrName() + "-" + property.ShortName);
//             // }
//             //
//             // return ShowUnityHelp.FormatDocumentationKeyword(compiledElement.GetSearchableText());
//         }
//
//         // same priority as MsdnOnlineHelpProvider,
//         // but this provider only applies to Unity* assemblies and MSDN only applies to Microsoft/Mono
//         public override int Priority => 10;
//         public override bool ShouldValidate => false;
//     }
// }

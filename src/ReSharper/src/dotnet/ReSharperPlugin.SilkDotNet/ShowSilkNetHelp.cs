// // Licensed to the .NET Foundation under one or more agreements.
// // The .NET Foundation licenses this file to you under the MIT license.
//
// using System;
// using JetBrains.Annotations;
// using JetBrains.Application;
// using JetBrains.Application.StdApplicationUI;
// using JetBrains.Application.UI.Help;
// using JetBrains.ProjectModel;
// using JetBrains.ReSharper.Psi.Modules;
// using JetBrains.Util;
//
// namespace ReSharperPlugin.SilkDotNet
// {
//     [ShellComponent]
//     public class ShowSilkNetHelp : IShowHelp
//     {
//         private readonly OpensUri myUriOpener;
//         private readonly SolutionsManager mySolutionsManager;
//
//         public ShowSilkNetHelp(OpensUri uriOpener, SolutionsManager solutionsManager)
//         {
//             myUriOpener = uriOpener;
//             mySolutionsManager = solutionsManager;
//         }
//
//         public bool ShowHelp(string keyword, HelpSystem.HelpKind kind, string preferredProduct = "")
//         {
//             if (kind != HelpSystem.HelpKind.Msdn) return false;
//             if (!IsUnityKeyword(keyword)) return false;
//             keyword = StripPrefix(keyword);
//
//             var uri = GetUri(keyword);
//             myUriOpener.OpenUri(uri);
//
//             return true;
//         }
//
//         // Must be less than `VsShowMsdnHelp` so we get a shot at handling it
//         public double Priority => 0;
//         public HelpSystem.HelpKind[] SupportedKinds => new[] {HelpSystem.HelpKind.Msdn};
//
//         private static bool IsUnityKeyword(string keyword)
//         {
//             return keyword.StartsWith("UnityEngine.", StringComparison.OrdinalIgnoreCase)
//                    || keyword.StartsWith("UnityEditor.", StringComparison.OrdinalIgnoreCase);
//         }
//
//         private static string StripPrefix(string keyword)
//         {
//             // We know the string starts with `UnityEngine.` or `UnityEditor.`
//             return keyword.Substring(12);
//         }
//
//         public static string FormatDocumentationKeyword(string keyword)
//         {
//             if (keyword == null)
//                 return null;
//
//             if (IsUnityKeyword(keyword))
//                 return StripPrefix(keyword);
//             return keyword;
//         }
//
//         [NotNull]
//         public Uri GetUri([NotNull] string keyword)
//         {
//             return new Uri("https://google.au");
//             // var documentationRoot = GetDocumentationRoot();
//             // return GetFileUri(documentationRoot, $"ScriptReference/{keyword}.html")
//             //        ?? GetFileUri(documentationRoot, $"ScriptReference/{keyword.Replace('.', '-')}.html")
//             //        ?? new Uri
//             //        (
//             //            $"https://docs.unity3d.com{GetVersionSpecificPieceOfUrl()}/ScriptReference/30_search.html?q={keyword}"
//             //        );
//         }
//
//         // private string GetVersionSpecificPieceOfUrl()
//         // {
//         //     var version = mySolutionsManager.Solution?.GetComponent<UnityVersion>().ActualVersionForSolution.Value;
//         //     if (version == null)
//         //         return string.Empty;
//         //
//         //     // Version before 2017.1 has different format of version:
//         //     // https://docs.unity3d.com/560/Documentation/ScriptReference/MonoBehaviour.html
//         //     if (version < new Version(2017, 1))
//         //         return $"/{version.Major}{version.Minor}0/Documentation";
//         //     return $"/{version.ToString(2)}/Documentation";
//         // }
//
//         // [NotNull]
//         // private FileSystemPath GetDocumentationRoot()
//         // {
//         //     var appPath = mySolutionsManager.Solution?.GetComponent<UnityVersion>().GetActualAppPathForSolution();
//         //     var contentsPath = UnityInstallationFinder.GetApplicationContentsPath(appPath);
//         //     var root = contentsPath.Combine("Documentation");
//         //     var englishRoot = root.Combine("en");
//         //     if (!englishRoot.ExistsDirectory)
//         //         return root.GetChildDirectories().FirstOrDefault(englishRoot);
//         //     return englishRoot;
//         // }
//
//         // [CanBeNull]
//         // private static Uri GetFileUri([NotNull] FileSystemPath documentationRoot, string htmlPath)
//         // {
//         //     if (documentationRoot.IsEmpty)
//         //         return null;
//         //
//         //     var fileSystemPath = documentationRoot / htmlPath;
//         //     return fileSystemPath.IsAbsolute && fileSystemPath.ExistsFile ? fileSystemPath.ToUri() : null;
//         // }
//     }
// }

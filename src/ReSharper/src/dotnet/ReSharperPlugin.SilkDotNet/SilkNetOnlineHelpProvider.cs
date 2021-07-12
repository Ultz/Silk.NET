// // Licensed to the .NET Foundation under one or more agreements.
// // The .NET Foundation licenses this file to you under the MIT license.
//
// using System;
// using JetBrains.Application;
// using JetBrains.ReSharper.Feature.Services.OnlineHelp;
// using JetBrains.ReSharper.Psi;
//
// namespace ReSharperPlugin.SilkDotNet
// {
//     // [ShellComponent]
//     // public class SilkNetOnlineHelpProvider : IOnlineHelpProvider
//     // {
//     //     // private readonly ShowUnityHelp myShowUnityHelp;
//     //     //
//     //     // public UnityOnlineHelpProvider(ShowUnityHelp showUnityHelp)
//     //     // {
//     //     //     myShowUnityHelp = showUnityHelp;
//     //     // }
//     //
//     //     public Uri GetUrl(IDeclaredElement element)
//     //     {
//     //         return new Uri("https://google.de");
//     //         // if (!IsAvailable(element)) return null;
//     //         // var unityApi = element.GetSolution().GetComponent<UnityApi>();
//     //         // var keyword = element.GetUnityEventFunctionName(unityApi);
//     //         // keyword = ShowUnityHelp.FormatDocumentationKeyword(keyword);
//     //         // if (keyword == null) return null;
//     //         // return myShowUnityHelp.GetUri(keyword);
//     //     }
//     //
//     //     public bool IsAvailable(IDeclaredElement element)
//     //     {
//     //         return true;
//     //         // return element.IsFromUnityProject();
//     //     }
//     //
//     //     public int Priority => 20; // for now there are no other providers like this one
//     //     public bool ShouldValidate => false;
//     // }
// }

<h1 align="center">
    <a href="#"><img align="center" src="documentation/readme/wordmark480.png" height="96"></a>
    <br />
</h1>
<div align="center">

[![NuGet Version](https://img.shields.io/nuget/v/Silk.NET)](https://nuget.org/packages/Silk.NET)
[![Preview Feed](https://img.shields.io/badge/nuget-experimental%20feed-yellow)](https://dev.azure.com/UltzOS/Silk.NET/_packaging?_a=feed&feed=Experimental)
[![CI Build](https://github.com/Ultz/Silk.NET/workflows/CI%20Build/badge.svg)](https://github.com/dotnet/Silk.NET/actions/workflows/build.yml)
[![Join our Discord](https://img.shields.io/badge/chat%20on-discord-7289DA)](https://discord.gg/DTHHXRt)

</div>

<div> 

Silk.NET is your one-stop-shop for high-speed .NET multimedia, graphics, and compute; providing bindings to popular low-level APIs such as OpenGL, OpenCL, OpenAL, OpenXR, GLFW, SDL, Vulkan, Assimp, and DirectX.

Use Silk.NET to spruce up applications with cross-platform 3D graphics, audio, compute and haptics!

Silk.NET works on any .NET Standard 2.0 compliant platform, including .NET 5.0, Xamarin, .NET Framework 4.6.1+, and .NET Core 2.0+.

</div>
<br />
<div>
    <a href="https://dotnetfoundation.org" align="right"><img src="https://dotnetfoundation.org/img/logo_v4.svg" alt=".NET Foundation" class="logo-footer" width="72" align="left">
    <a><br/>
        Proud to be an official project under the benevolent <a href="https://dotnetfoundation.org">.NET Foundation</a> umbrella. </a>
</div>

<br />

<h1 align="center">Features</h1>

### Performance
Having poured lots of hours into examining generated C# code and its JIT assembly, you can count on us to deliver blazing fast bindings with negligible overhead induced by Silk.NET!

### Up-to-date
With an efficient bindings regeneration mechanism, we are committed to ensuring our bindings reflect the latest specifications with monthly updates generated straight from the upstream sources.

### High-level utilities
In addition to providing high-speed, direct, and transparent bindings, we provide high-level utilities and wrappers to maximise productivity in common workloads such as platform-agnostic abstractions around Windowing and Input, bringing your apps to a vast number of platforms without changing a single line!

### Good-to-go
Silk.NET caters for anything you could need in swift development of multimedia, graphics, compute applications. Silk.NET is an all-in-one solution, complete with Graphics, Compute, Audio, Input, and Windowing.

<h1 align="center">The team</h1>

We currently have the following maintainers:
- [Dylan Perks](https://github.com/Perksey) [<img src="https://about.twitter.com/etc/designs/about2-twitter/public/img/favicon.ico" alt="Follow Dylan Perks on Twitter" width="16" />](https://twitter.com/intent/follow?screen_name=Dylan_Perks)
- [Kai Jellinghaus](https://github.com/HurricanKai)

In addition, the Silk.NET working group help drive larger user-facing changes providing key consultation from the perspective of dedicated users and professionals.

<h1 align="center">Building from source</h1>

- Make sure you have at least the .NET 5 SDK installed, preferably with Visual Studio's .NET Framework and Xamarin workloads too.
- Clone the repository
- Run build.sh, build.cmd, build.ps1, or `nuke build`. To build for iOS and Android, add the `--feature-sets ios android` arguments.

There are more advanced build actions you can do too, such as FullBuild, Pack, FullPack, among others which you can view by doing `nuke --plan`.

Some projects may not build properly without being configured to use Desktop MSBuild (i.e. the MSBuild shipped with Visual Studio). As a result, you will ideally need to be on Windows and have Visual Studio 2019 Community (or greater) installed with .NET Core and Xamarin workloads. If you don't have this (i.e. because you're on Linux or Mac), you can still develop Silk.NET in a limited capacity but you will not be able to work on mobile workloads.

<h1 align="center">Contributing</h1>

Silk.NET uses and encourages [Early Pull Requests](https://medium.com/practical-blend/pull-request-first-f6bb667a9b6). Please don't wait until you're done to open a PR!

1. [Fork Silk.NET](https://github.com/dotnet/Silk.NET/fork)
2. Add an empty commit to a new branch to start your work off: `git commit --allow-empty -m "start of [thing you're working on]"`
3. Once you've pushed a commit, open a [**draft pull request**](https://github.blog/2019-02-14-introducing-draft-pull-requests/). Do this **before** you actually start working.
4. Make your commits in small, incremental steps with clear descriptions.
5. Tag a maintainer when you're done and ask for a review!
    
<h2 align="center">Funding</h2>
Silk.NET requires significant effort to maintain, as such we greatly appreciate any financial support you are able to provide!

This helps ensure Silk.NET's long term viability, and to help support the developers who maintain Silk.NET in their free time. [Dylan](https://github.com/sponsors/Perksey) and [Kai](https://github.com/sponsors/HurricanKai) are accepting GitHub Sponsorships.

<h1 align="center">Further resources</h1>

- Several examples can be found in the [examples folder](https://github.com/dotnet/Silk.NET/tree/master/examples)
- Come chat with us on [Discord](https://discord.gg/DTHHXRt)!

<h1 align="center">Licensing and governance</h1>

Silk.NET is distributed under the very permissive MIT/X11 license and all dependencies are distributed under MIT-compatible licenses.

Silk.NET is a [.NET Foundation](https://www.dotnetfoundation.org/projects) project, and has adopted the code of conduct defined by the [Contributor Covenant](http://contributor-covenant.org/) to clarify expected behavior in our community. For more information, see the [.NET Foundation Code of Conduct](http://www.dotnetfoundation.org/code-of-conduct).

---

<div>
    <a href="https://www.jetbrains.com/?from=Silk.NET" align="right"><img src="documentation/readme/jetbrains.svg" alt="JetBrains" class="logo-footer" width="72" align="left">
    <a><br/>
        
Special thanks to [JetBrains](https://www.jetbrains.com/?from=Silk.NET) for supporting us with open-source licenses for their IDEs. </a>
</div>

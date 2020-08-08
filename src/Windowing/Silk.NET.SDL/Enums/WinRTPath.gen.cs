// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_system_L209_C9")]
    [NativeName("Name", "SDL_WinRT_Path")]
    public enum WinRTPath
    {
        [NativeName("Name", "SDL_WINRT_PATH_INSTALLED_LOCATION")]
        WinrtPathInstalledLocation = 0x0,
        [NativeName("Name", "SDL_WINRT_PATH_LOCAL_FOLDER")]
        WinrtPathLocalFolder = 0x1,
        [NativeName("Name", "SDL_WINRT_PATH_ROAMING_FOLDER")]
        WinrtPathRoamingFolder = 0x2,
        [NativeName("Name", "SDL_WINRT_PATH_TEMP_FOLDER")]
        WinrtPathTempFolder = 0x3,
    }
}

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.OpenXR
{
    /// <summary>
    /// Contains the library name of OpenXR.
    /// </summary>
    internal class OpenXRLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string Linux => "libopenxr_loader.so.1";

        /// <inheritdoc />
        public override string MacOS => "null";

        /// <inheritdoc />
        public override string Android => "libopenxr_loader.so.1";

        /// <inheritdoc />
        public override string IOS => "__Internal";

        /// <inheritdoc />
        public override string Windows64 => "openxr_loader.dll";

        /// <inheritdoc />
        public override string Windows86 => "openxr_loader.dll";
    }
}

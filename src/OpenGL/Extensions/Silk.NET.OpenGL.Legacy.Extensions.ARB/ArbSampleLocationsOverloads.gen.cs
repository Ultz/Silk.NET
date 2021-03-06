// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    public static class ArbSampleLocationsOverloads
    {
        public static unsafe void FramebufferSampleLocations(this ArbSampleLocations thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.FramebufferSampleLocations(target, start, count, in v.GetPinnableReference());
        }

        public static unsafe void FramebufferSampleLocations(this ArbSampleLocations thisApi, [Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.FramebufferSampleLocations(target, start, count, in v.GetPinnableReference());
        }

        public static unsafe void NamedFramebufferSampleLocations(this ArbSampleLocations thisApi, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.NamedFramebufferSampleLocations(framebuffer, start, count, in v.GetPinnableReference());
        }

    }
}


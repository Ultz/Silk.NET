// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    public static class SgixAsyncOverloads
    {
        public static unsafe int FinishAsync(this SgixAsync thisApi, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> markerp)
        {
            // SpanOverloader
            return thisApi.FinishAsync(out markerp.GetPinnableReference());
        }

        public static unsafe int PollAsync(this SgixAsync thisApi, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> markerp)
        {
            // SpanOverloader
            return thisApi.PollAsync(out markerp.GetPinnableReference());
        }

    }
}


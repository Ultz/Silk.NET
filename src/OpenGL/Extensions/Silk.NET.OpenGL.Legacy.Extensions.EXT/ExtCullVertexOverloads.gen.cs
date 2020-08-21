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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    public static class ExtCullVertexOverloads
    {
        public static unsafe void CullParameter(this ExtCullVertex thisApi, [Flow(FlowDirection.In)] EXT pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.CullParameter(pname, out @params.GetPinnableReference());
        }

        public static unsafe void CullParameter(this ExtCullVertex thisApi, [Flow(FlowDirection.In)] CullParameterEXT pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.CullParameter(pname, out @params.GetPinnableReference());
        }

        public static unsafe void CullParameter(this ExtCullVertex thisApi, [Flow(FlowDirection.In)] EXT pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.CullParameter(pname, out @params.GetPinnableReference());
        }

        public static unsafe void CullParameter(this ExtCullVertex thisApi, [Flow(FlowDirection.In)] CullParameterEXT pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.CullParameter(pname, out @params.GetPinnableReference());
        }

    }
}


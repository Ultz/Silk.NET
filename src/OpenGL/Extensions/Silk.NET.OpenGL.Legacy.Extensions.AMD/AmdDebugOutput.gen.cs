// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    [Extension("AMD_debug_output")]
    public unsafe partial class AmdDebugOutput : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_debug_output";
        [NativeApi(EntryPoint = "glDebugMessageCallbackAMD")]
        public unsafe partial void DebugMessageCallback([Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] DebugProcAmd callback, [Flow(FlowDirection.Out)] void* userParam);

        [NativeApi(EntryPoint = "glDebugMessageCallbackAMD")]
        public partial void DebugMessageCallback<T0>([Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] DebugProcAmd callback, [Flow(FlowDirection.Out)] Span<T0> userParam) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDebugMessageEnableAMD")]
        public unsafe partial void DebugMessageEnable([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] AMD severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageEnableAMD")]
        public partial void DebugMessageEnable([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] AMD severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageInsertAMD")]
        public unsafe partial void DebugMessageInsert([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] AMD severity, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] byte* buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertAMD")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] AMD severity, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] Span<byte> buf);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> message);

        [NativeApi(EntryPoint = "glDebugMessageEnableAMD")]
        public unsafe partial void DebugMessageEnable([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageEnableAMD")]
        public partial void DebugMessageEnable([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageInsertAMD")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] string buf);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string message);

        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string message);

        public AmdDebugOutput(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}


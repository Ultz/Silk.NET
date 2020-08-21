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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    public static class KhrExternalMemoryWin32Overloads
    {
        /// <summary>To be added.</summary>
        public static unsafe Result GetMemoryWin32Handle(this KhrExternalMemoryWin32 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] MemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, [Count(Count = 0), Flow(FlowDirection.Out)] Span<IntPtr> pHandle)
        {
            // SpanOverloader
            return thisApi.GetMemoryWin32Handle(device, pGetWin32HandleInfo, out pHandle.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetMemoryWin32Handle(this KhrExternalMemoryWin32 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<MemoryGetWin32HandleInfoKHR> pGetWin32HandleInfo, [Count(Count = 0), Flow(FlowDirection.Out)] IntPtr* pHandle)
        {
            // SpanOverloader
            return thisApi.GetMemoryWin32Handle(device, in pGetWin32HandleInfo.GetPinnableReference(), pHandle);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetMemoryWin32Handle(this KhrExternalMemoryWin32 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<MemoryGetWin32HandleInfoKHR> pGetWin32HandleInfo, [Count(Count = 0), Flow(FlowDirection.Out)] Span<IntPtr> pHandle)
        {
            // SpanOverloader
            return thisApi.GetMemoryWin32Handle(device, in pGetWin32HandleInfo.GetPinnableReference(), out pHandle.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetMemoryWin32HandleProperties(this KhrExternalMemoryWin32 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] IntPtr handle, [Count(Count = 0), Flow(FlowDirection.Out)] Span<MemoryWin32HandlePropertiesKHR> pMemoryWin32HandleProperties)
        {
            // SpanOverloader
            return thisApi.GetMemoryWin32HandleProperties(device, handleType, handle, out pMemoryWin32HandleProperties.GetPinnableReference());
        }

    }
}


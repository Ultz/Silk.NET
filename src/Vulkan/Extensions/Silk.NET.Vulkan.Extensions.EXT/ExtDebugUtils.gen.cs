// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_debug_utils")]
    public unsafe partial class ExtDebugUtils : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_debug_utils";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginDebugUtilsLabelEXT")]
        public unsafe partial void CmdBeginDebugUtilsLabel([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsLabelEXT* pLabelInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginDebugUtilsLabelEXT")]
        public partial void CmdBeginDebugUtilsLabel([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in DebugUtilsLabelEXT pLabelInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdEndDebugUtilsLabelEXT")]
        public partial void CmdEndDebugUtilsLabel([Count(Count = 0)] CommandBuffer commandBuffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdInsertDebugUtilsLabelEXT")]
        public unsafe partial void CmdInsertDebugUtilsLabel([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsLabelEXT* pLabelInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdInsertDebugUtilsLabelEXT")]
        public partial void CmdInsertDebugUtilsLabel([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in DebugUtilsLabelEXT pLabelInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugUtilsMessengerEXT")]
        public unsafe partial Result CreateDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsMessengerCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DebugUtilsMessengerEXT* pMessenger);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugUtilsMessengerEXT")]
        public unsafe partial Result CreateDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsMessengerCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DebugUtilsMessengerEXT pMessenger);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugUtilsMessengerEXT")]
        public unsafe partial Result CreateDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsMessengerCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DebugUtilsMessengerEXT* pMessenger);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugUtilsMessengerEXT")]
        public unsafe partial Result CreateDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsMessengerCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DebugUtilsMessengerEXT pMessenger);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugUtilsMessengerEXT")]
        public unsafe partial Result CreateDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in DebugUtilsMessengerCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DebugUtilsMessengerEXT* pMessenger);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugUtilsMessengerEXT")]
        public unsafe partial Result CreateDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in DebugUtilsMessengerCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DebugUtilsMessengerEXT pMessenger);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugUtilsMessengerEXT")]
        public unsafe partial Result CreateDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in DebugUtilsMessengerCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DebugUtilsMessengerEXT* pMessenger);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugUtilsMessengerEXT")]
        public partial Result CreateDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in DebugUtilsMessengerCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DebugUtilsMessengerEXT pMessenger);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDebugUtilsMessengerEXT")]
        public unsafe partial void DestroyDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugUtilsMessengerEXT messenger, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDebugUtilsMessengerEXT")]
        public partial void DestroyDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugUtilsMessengerEXT messenger, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkQueueBeginDebugUtilsLabelEXT")]
        public unsafe partial void QueueBeginDebugUtilsLabel([Count(Count = 0)] Queue queue, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsLabelEXT* pLabelInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkQueueBeginDebugUtilsLabelEXT")]
        public partial void QueueBeginDebugUtilsLabel([Count(Count = 0)] Queue queue, [Count(Count = 0), Flow(FlowDirection.In)] in DebugUtilsLabelEXT pLabelInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkQueueEndDebugUtilsLabelEXT")]
        public partial void QueueEndDebugUtilsLabel([Count(Count = 0)] Queue queue);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkQueueInsertDebugUtilsLabelEXT")]
        public unsafe partial void QueueInsertDebugUtilsLabel([Count(Count = 0)] Queue queue, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsLabelEXT* pLabelInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkQueueInsertDebugUtilsLabelEXT")]
        public partial void QueueInsertDebugUtilsLabel([Count(Count = 0)] Queue queue, [Count(Count = 0), Flow(FlowDirection.In)] in DebugUtilsLabelEXT pLabelInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkSetDebugUtilsObjectNameEXT")]
        public unsafe partial Result SetDebugUtilsObjectName([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsObjectNameInfoEXT* pNameInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkSetDebugUtilsObjectNameEXT")]
        public partial Result SetDebugUtilsObjectName([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in DebugUtilsObjectNameInfoEXT pNameInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkSetDebugUtilsObjectTagEXT")]
        public unsafe partial Result SetDebugUtilsObjectTag([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsObjectTagInfoEXT* pTagInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkSetDebugUtilsObjectTagEXT")]
        public partial Result SetDebugUtilsObjectTag([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in DebugUtilsObjectTagInfoEXT pTagInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkSubmitDebugUtilsMessageEXT")]
        public unsafe partial void SubmitDebugUtilsMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugUtilsMessageSeverityFlagsEXT messageSeverity, [Count(Count = 0)] DebugUtilsMessageTypeFlagsEXT messageTypes, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsMessengerCallbackDataEXT* pCallbackData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkSubmitDebugUtilsMessageEXT")]
        public partial void SubmitDebugUtilsMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugUtilsMessageSeverityFlagsEXT messageSeverity, [Count(Count = 0)] DebugUtilsMessageTypeFlagsEXT messageTypes, [Count(Count = 0), Flow(FlowDirection.In)] in DebugUtilsMessengerCallbackDataEXT pCallbackData);

        public ExtDebugUtils(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}


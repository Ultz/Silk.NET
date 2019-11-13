using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedDLSupport.AOT;
using AdvancedDLSupport.Loaders;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;

namespace Silk.NET.Vulkan
{
    public partial class Vk
    {
        private ISymbolLoader _extLoader;
        public Instance? CurrentInstance { get; set; }
        public Device? CurrentDevice { get; set; }
        public static Vk GetApi()
        {
            var sym = new VkLoader(PlatformLoaderBase.PlatformLoader);
            var ret = LibraryLoader<Vk>.Load(new VulkanLibraryNameContainer(), sym);
            sym.Vulkan = ret;
            return ret;
        }

        public bool TryGetExtension<T>(out T ext)
            where T:NativeExtension<Vk>
        {
            ext = LibraryLoader<Vk>.Load<T>
                (this, SearchPaths, _extLoader ??= new VkLoader(this, PlatformLoaderBase.PlatformLoader));
            return ext != null;
        }

        public override bool IsExtensionPresent(string extension)
        {
            return GetExtensions().Contains(extension);
        }

        private unsafe List<string> GetExtensions()
        {
            var l = new List<string>();
            var result = Result.Incomplete;
            var props = stackalloc ExtensionProperties[128];
            while (result == Result.Incomplete)
            {
                var instanceExtPropertiesCount = 128u;
                result = EnumerateInstanceExtensionProperties((byte*) 0, &instanceExtPropertiesCount, props);
                if (result == Result.Success || result == Result.Incomplete)
                {
                    for (var i = 0; i < instanceExtPropertiesCount; i++)
                    {
                        l.Add(Marshal.PtrToStringAnsi((IntPtr) props[i].ExtensionName));
                    }
                }
            }

            return l;
        }
    }
}


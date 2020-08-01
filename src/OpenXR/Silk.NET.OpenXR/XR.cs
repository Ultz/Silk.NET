using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using ExtensionAttribute = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    public partial class XR
    {
        public Instance? CurrentInstance { get; set; }
        public static XR GetApi()
        {
             var ret = new XR(new DefaultNativeContext(new OpenXRLibraryNameContainer().GetLibraryName()));
             return ret;
        }

        [Obsolete("Use IsInstanceExtensionPresent instead.", true)]
        public override bool IsExtensionPresent(string extension) => IsInstanceExtensionPresent(null, extension);
        private Dictionary<string, List<string>> _cachedInstanceExtensions = new Dictionary<string, List<string>>();

        /// <summary>
        /// Attempts to load the given instance extension.
        /// </summary>
        /// <param name="instance">The instance to load the extension from.</param>
        /// <param name="ext">The loaded instance extension, or null if load failed.</param>
        /// <typeparam name="T">The instance extension to load.</typeparam>
        /// <remarks>
        /// This function doesn't check that the extension is enabled - you will get an error later on if you attempt
        /// to call an extension function from an extension that isn't loaded.
        /// </remarks>
        /// <returns>Whether the extension is available and loaded.</returns>
        public bool TryGetInstanceExtension<T>(string layer, Instance instance, out T ext) where T:NativeExtension<XR> =>
            !((ext = IsInstanceExtensionPresent(layer, ExtensionAttribute.GetExtensionAttribute(typeof(T)).Name)
                ? (T)Activator.CreateInstance
                    (typeof(T), new LamdaNativeContext(
                    x =>
                    {
                        FuncPtr ptr;
                        var result = GetInstanceProcAddr(instance, x, ref ptr);
                        if (result != Result.Success)
                        {
                            throw new InvalidOperationException($"Symbol loading failed with XrResult {result}");
                        }

                        return ptr.Value;
                    }))
                : null) is null);

        /// <summary>
        /// Checks whether the given instance extension is available.
        /// </summary>
        /// <param name="extension">The instance extension name.</param>
        /// <returns>Whether the instance extension is available.</returns>
        public unsafe bool IsInstanceExtensionPresent(string layer, string extension)
        {
            layer ??= string.Empty;
            if (_cachedInstanceExtensions.TryGetValue(layer, out var val))
            {
                return val.Contains(extension);
            }

            var l = new List<string>();
            if (string.IsNullOrWhiteSpace(layer))
            {
                var layerCount = 0u;
                EnumerateApiLayerProperties(0, ref layerCount, ref Unsafe.AsRef<ApiLayerProperties>(null));
                var layers = stackalloc ApiLayerProperties[(int)layerCount];
                EnumerateApiLayerProperties(0, ref layerCount, ref layers[0]);
                for (var i = 0; i < layerCount; i++)
                {
                    Add(l, layers[i].LayerName);
                }
            }
            else
            {
                var layerName = SilkMarshal.MarshalStringToPtr(layer);
                Add(l, (byte*) layerName);
                SilkMarshal.FreeStringPtr(layerName);
            }

            _cachedInstanceExtensions[layer] = l;

            return l.Contains(extension);
        }

        private unsafe void Add(ICollection<string> extensions, byte* layerName)
        {
            var extensionCount = 0u;
            EnumerateInstanceExtensionProperties(layerName, extensionCount, &extensionCount, null);
            var exts = stackalloc ExtensionProperties[(int)extensionCount];
            EnumerateInstanceExtensionProperties(layerName, extensionCount, &extensionCount, exts);
            for (var i = 0; i < extensionCount; i++)
            {
                extensions.Add(Marshal.PtrToStringAnsi((IntPtr) exts[i].ExtensionName));
            }
        }
    }
}


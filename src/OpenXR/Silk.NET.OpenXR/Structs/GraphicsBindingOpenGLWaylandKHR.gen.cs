// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrGraphicsBindingOpenGLWaylandKHR")]
    public unsafe partial struct GraphicsBindingOpenGLWaylandKHR
    {
        public GraphicsBindingOpenGLWaylandKHR
        (
            StructureType type = StructureType.TypeGraphicsBindingOpenglWaylandKhr,
            void* next = default,
            IntPtr* display = default
        )
        {
            Type = type;
            Next = next;
            Display = display;
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "wl_display*")]
        [NativeName("Type.Name", "wl_display")]
        [NativeName("Name", "display")]
        public IntPtr* Display;
    }
}
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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrEventDataReferenceSpaceChangePending")]
    public unsafe partial struct EventDataReferenceSpaceChangePending
    {
        public EventDataReferenceSpaceChangePending
        (
            StructureType? type = StructureType.TypeEventDataReferenceSpaceChangePending,
            void* next = null,
            Session? session = null,
            ReferenceSpaceType? referenceSpaceType = null,
            long? changeTime = null,
            uint? poseValid = null,
            Posef? poseInPreviousSpace = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (session is not null)
            {
                Session = session.Value;
            }

            if (referenceSpaceType is not null)
            {
                ReferenceSpaceType = referenceSpaceType.Value;
            }

            if (changeTime is not null)
            {
                ChangeTime = changeTime.Value;
            }

            if (poseValid is not null)
            {
                PoseValid = poseValid.Value;
            }

            if (poseInPreviousSpace is not null)
            {
                PoseInPreviousSpace = poseInPreviousSpace.Value;
            }
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
        [NativeName("Type", "XrSession")]
        [NativeName("Type.Name", "XrSession")]
        [NativeName("Name", "session")]
        public Session Session;
/// <summary></summary>
        [NativeName("Type", "XrReferenceSpaceType")]
        [NativeName("Type.Name", "XrReferenceSpaceType")]
        [NativeName("Name", "referenceSpaceType")]
        public ReferenceSpaceType ReferenceSpaceType;
/// <summary></summary>
        [NativeName("Type", "XrTime")]
        [NativeName("Type.Name", "XrTime")]
        [NativeName("Name", "changeTime")]
        public long ChangeTime;
/// <summary></summary>
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "poseValid")]
        public uint PoseValid;
/// <summary></summary>
        [NativeName("Type", "XrPosef")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "poseInPreviousSpace")]
        public Posef PoseInPreviousSpace;
    }
}

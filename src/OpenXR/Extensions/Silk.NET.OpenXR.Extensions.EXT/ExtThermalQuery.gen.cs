// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenXR;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.EXT
{
    [Extension("XR_EXT_thermal_query")]
    public unsafe partial class ExtThermalQuery : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_EXT_thermal_query";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrThermalGetTemperatureTrendEXT")]
        public unsafe partial Result ThermalGetTemperatureTrend([Count(Count = 0)] Session session, [Count(Count = 0)] PerfSettingsDomainEXT domain, [Count(Count = 0)] PerfSettingsNotificationLevelEXT* notificationLevel, [Count(Count = 0)] float* tempHeadroom, [Count(Count = 0)] float* tempSlope);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrThermalGetTemperatureTrendEXT")]
        public unsafe partial Result ThermalGetTemperatureTrend([Count(Count = 0)] Session session, [Count(Count = 0)] PerfSettingsDomainEXT domain, [Count(Count = 0)] PerfSettingsNotificationLevelEXT* notificationLevel, [Count(Count = 0)] float* tempHeadroom, [Count(Count = 0)] ref float tempSlope);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrThermalGetTemperatureTrendEXT")]
        public unsafe partial Result ThermalGetTemperatureTrend([Count(Count = 0)] Session session, [Count(Count = 0)] PerfSettingsDomainEXT domain, [Count(Count = 0)] PerfSettingsNotificationLevelEXT* notificationLevel, [Count(Count = 0)] ref float tempHeadroom, [Count(Count = 0)] float* tempSlope);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrThermalGetTemperatureTrendEXT")]
        public unsafe partial Result ThermalGetTemperatureTrend([Count(Count = 0)] Session session, [Count(Count = 0)] PerfSettingsDomainEXT domain, [Count(Count = 0)] PerfSettingsNotificationLevelEXT* notificationLevel, [Count(Count = 0)] ref float tempHeadroom, [Count(Count = 0)] ref float tempSlope);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrThermalGetTemperatureTrendEXT")]
        public unsafe partial Result ThermalGetTemperatureTrend([Count(Count = 0)] Session session, [Count(Count = 0)] PerfSettingsDomainEXT domain, [Count(Count = 0)] ref PerfSettingsNotificationLevelEXT notificationLevel, [Count(Count = 0)] float* tempHeadroom, [Count(Count = 0)] float* tempSlope);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrThermalGetTemperatureTrendEXT")]
        public unsafe partial Result ThermalGetTemperatureTrend([Count(Count = 0)] Session session, [Count(Count = 0)] PerfSettingsDomainEXT domain, [Count(Count = 0)] ref PerfSettingsNotificationLevelEXT notificationLevel, [Count(Count = 0)] float* tempHeadroom, [Count(Count = 0)] ref float tempSlope);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrThermalGetTemperatureTrendEXT")]
        public unsafe partial Result ThermalGetTemperatureTrend([Count(Count = 0)] Session session, [Count(Count = 0)] PerfSettingsDomainEXT domain, [Count(Count = 0)] ref PerfSettingsNotificationLevelEXT notificationLevel, [Count(Count = 0)] ref float tempHeadroom, [Count(Count = 0)] float* tempSlope);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrThermalGetTemperatureTrendEXT")]
        public partial Result ThermalGetTemperatureTrend([Count(Count = 0)] Session session, [Count(Count = 0)] PerfSettingsDomainEXT domain, [Count(Count = 0)] ref PerfSettingsNotificationLevelEXT notificationLevel, [Count(Count = 0)] ref float tempHeadroom, [Count(Count = 0)] ref float tempSlope);

        public ExtThermalQuery(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}


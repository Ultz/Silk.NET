// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    public enum INTEL
    {
        AcceleratorDescriptorIntel = 0x4090,
        AcceleratorReferenceCountIntel = 0x4091,
        AcceleratorContextIntel = 0x4092,
        AcceleratorTypeIntel = 0x4093,
        InvalidAcceleratorIntel = unchecked((int)0xFFFFFFFFFFFFFBBA),
        InvalidAcceleratorTypeIntel = unchecked((int)0xFFFFFFFFFFFFFBB9),
        InvalidAcceleratorDescriptorIntel = unchecked((int)0xFFFFFFFFFFFFFBB8),
        AcceleratorTypeNotSupportedIntel = unchecked((int)0xFFFFFFFFFFFFFBB7),
        DeviceMEVersionIntel = 0x407E,
        MESkipBlockType16x16Intel = 0x0,
        MEChromaIntraPredictEnabledIntel = 0x1,
        MELumaIntraPredictEnabledIntel = 0x2,
        MESkipBlockType8x8Intel = 0x1,
        MECostPenaltyNoneIntel = 0x0,
        MECostPenaltyLowIntel = 0x1,
        MECostPenaltyNormalIntel = 0x2,
        MECostPenaltyHighIntel = 0x3,
        MECostPrecisionQpelIntel = 0x0,
        MECostPrecisionHpelIntel = 0x1,
        MECostPrecisionPelIntel = 0x2,
        MECostPrecisionDpelIntel = 0x3,
        MELumaPredictorModeVerticalIntel = 0x0,
        MELumaPredictorModeHorizontalIntel = 0x1,
        MELumaPredictorModeDCIntel = 0x2,
        MELumaPredictorModeDiagonalDownLeftIntel = 0x3,
        MELumaPredictorModeDiagonalDownRightIntel = 0x4,
        MELumaPredictorModePlaneIntel = 0x4,
        MELumaPredictorModeVerticalRightIntel = 0x5,
        MELumaPredictorModeHorizontalDownIntel = 0x6,
        MELumaPredictorModeVerticalLeftIntel = 0x7,
        MELumaPredictorModeHorizontalUpIntel = 0x8,
        MEChromaPredictorModeDCIntel = 0x0,
        MEChromaPredictorModeHorizontalIntel = 0x1,
        MEChromaPredictorModeVerticalIntel = 0x2,
        MEChromaPredictorModePlaneIntel = 0x3,
        MEVersionLegacyIntel = 0x0,
        MEVersionAdvancedVer1Intel = 0x1,
        MEVersionAdvancedVer2Intel = 0x2,
        MEMBType16x16Intel = 0x0,
        MEMBType8x8Intel = 0x1,
        MEMBType4x4Intel = 0x2,
        MEForwardInputModeIntel = 0x1,
        MEBackwardInputModeIntel = 0x2,
        MEBidirectionInputModeIntel = 0x3,
        MEBidirWeightQuarterIntel = 0x16,
        MEBidirWeightThirdIntel = 0x21,
        MEBidirWeightHalfIntel = 0x32,
        MEBidirWeightTwoThirdIntel = 0x43,
        MEBidirWeightThreeQuarterIntel = 0x48,
        DevicePartitionByNamesIntel = 0x4052,
        DeviceAvcMEVersionIntel = 0x410B,
        DeviceAvcMESupportsTextureSamplerUseIntel = 0x410C,
        DeviceAvcMESupportsPreemptionIntel = 0x410D,
        AvcMEVersion0Intel = 0x0,
        AvcMEVersion1Intel = 0x1,
        AvcMEMajor16x16Intel = 0x0,
        AvcMEMajor16x8Intel = 0x1,
        AvcMEMajor8x16Intel = 0x2,
        AvcMEMajor8x8Intel = 0x3,
        AvcMEMinor8x8Intel = 0x0,
        AvcMEMinor8x4Intel = 0x1,
        AvcMEMinor4x8Intel = 0x2,
        AvcMEMinor4x4Intel = 0x3,
        AvcMEMajorForwardIntel = 0x0,
        AvcMEMajorBackwardIntel = 0x1,
        AvcMEMajorBidirectionalIntel = 0x2,
        AvcMEPartitionMaskAllIntel = 0x0,
        AvcMEPartitionMask16x16Intel = 0x7E,
        AvcMEPartitionMask16x8Intel = 0x7D,
        AvcMEPartitionMask8x16Intel = 0x7B,
        AvcMEPartitionMask8x8Intel = 0x77,
        AvcMEPartitionMask8x4Intel = 0x6F,
        AvcMEPartitionMask4x8Intel = 0x5F,
        AvcMEPartitionMask4x4Intel = 0x3F,
        AvcMESearchWindowExhaustiveIntel = 0x0,
        AvcMESearchWindowSmallIntel = 0x1,
        AvcMESearchWindowTinyIntel = 0x2,
        AvcMESearchWindowExtraTinyIntel = 0x3,
        AvcMESearchWindowDiamondIntel = 0x4,
        AvcMESearchWindowLargeDiamondIntel = 0x5,
        AvcMESearchWindowReserved0Intel = 0x6,
        AvcMESearchWindowReserved1Intel = 0x7,
        AvcMESearchWindowCustomIntel = 0x8,
        AvcMESearchWindow16x12RadiusIntel = 0x9,
        AvcMESearchWindow4x4RadiusIntel = 0x2,
        AvcMESearchWindow2x2RadiusIntel = 0xA,
        AvcMESadAdjustModeNoneIntel = 0x0,
        AvcMESadAdjustModeHaarIntel = 0x2,
        AvcMESubpixelModeIntegerIntel = 0x0,
        AvcMESubpixelModeHpelIntel = 0x1,
        AvcMESubpixelModeQpelIntel = 0x3,
        AvcMECostPrecisionQpelIntel = 0x0,
        AvcMECostPrecisionHpelIntel = 0x1,
        AvcMECostPrecisionPelIntel = 0x2,
        AvcMECostPrecisionDpelIntel = 0x3,
        AvcMEBidirWeightQuarterIntel = 0x10,
        AvcMEBidirWeightThirdIntel = 0x15,
        AvcMEBidirWeightHalfIntel = 0x20,
        AvcMEBidirWeightTwoThirdIntel = 0x2B,
        AvcMEBidirWeightThreeQuarterIntel = 0x30,
        AvcMEBorderReachedLeftIntel = 0x0,
        AvcMEBorderReachedRightIntel = 0x2,
        AvcMEBorderReachedTopIntel = 0x4,
        AvcMEBorderReachedBottomIntel = 0x8,
        AvcMESkipBlockPartition16x16Intel = 0x0,
        AvcMESkipBlockPartition8x8Intel = 0x4000,
        AvcMESkipBlock16x16ForwardEnableIntel = 16777216,
        AvcMESkipBlock16x16BackwardEnableIntel = 33554432,
        AvcMESkipBlock16x16DualEnableIntel = 50331648,
        AvcMESkipBlock8x8ForwardEnableIntel = 1426063360,
        AvcMESkipBlock8x8BackwardEnableIntel = -1442840576,
        AvcMESkipBlock8x8DualEnableIntel = -16777216,
        AvcMESkipBlock8x80ForwardEnableIntel = 16777216,
        AvcMESkipBlock8x80BackwardEnableIntel = 33554432,
        AvcMESkipBlock8x81ForwardEnableIntel = 67108864,
        AvcMESkipBlock8x81BackwardEnableIntel = 134217728,
        AvcMESkipBlock8x82ForwardEnableIntel = 268435456,
        AvcMESkipBlock8x82BackwardEnableIntel = 536870912,
        AvcMESkipBlock8x83ForwardEnableIntel = 1073741824,
        AvcMESkipBlock8x83BackwardEnableIntel = -2147483648,
        AvcMEBlockBasedSkip4x4Intel = 0x0,
        AvcMEBlockBasedSkip8x8Intel = 0x80,
        AvcMEIntra16x16Intel = 0x0,
        AvcMEIntra8x8Intel = 0x1,
        AvcMEIntra4x4Intel = 0x2,
        AvcMEIntraLumaPartitionMask16x16Intel = 0x6,
        AvcMEIntraLumaPartitionMask8x8Intel = 0x5,
        AvcMEIntraLumaPartitionMask4x4Intel = 0x3,
        AvcMEIntraNeighborLeftMaskEnableIntel = 0x60,
        AvcMEIntraNeighborUpperMaskEnableIntel = 0x10,
        AvcMEIntraNeighborUpperRightMaskEnableIntel = 0x8,
        AvcMEIntraNeighborUpperLeftMaskEnableIntel = 0x4,
        AvcMELumaPredictorModeVerticalIntel = 0x0,
        AvcMELumaPredictorModeHorizontalIntel = 0x1,
        AvcMELumaPredictorModeDCIntel = 0x2,
        AvcMELumaPredictorModeDiagonalDownLeftIntel = 0x3,
        AvcMELumaPredictorModeDiagonalDownRightIntel = 0x4,
        AvcMELumaPredictorModePlaneIntel = 0x4,
        AvcMELumaPredictorModeVerticalRightIntel = 0x5,
        AvcMELumaPredictorModeHorizontalDownIntel = 0x6,
        AvcMELumaPredictorModeVerticalLeftIntel = 0x7,
        AvcMELumaPredictorModeHorizontalUpIntel = 0x8,
        AvcMEChromaPredictorModeDCIntel = 0x0,
        AvcMEChromaPredictorModeHorizontalIntel = 0x1,
        AvcMEChromaPredictorModeVerticalIntel = 0x2,
        AvcMEChromaPredictorModePlaneIntel = 0x3,
        AvcMEFrameForwardIntel = 0x1,
        AvcMEFrameBackwardIntel = 0x2,
        AvcMEFrameDualIntel = 0x3,
        AvcMESliceTypePredIntel = 0x0,
        AvcMESliceTypeBpredIntel = 0x1,
        AvcMESliceTypeIntraIntel = 0x2,
        AvcMEInterlacedScanTopFieldIntel = 0x0,
        AvcMEInterlacedScanBottomFieldIntel = 0x1,
        ContextShowDiagnosticsIntel = 0x4106,
        ContextDiagnosticsLevelAllIntel = 0xFF,
        ContextDiagnosticsLevelGoodIntel = 0x1,
        ContextDiagnosticsLevelBadIntel = 0x2,
        ContextDiagnosticsLevelNeutralIntel = 0x4,
        InvalidDX9DeviceIntel = unchecked((int)0xFFFFFFFFFFFFFC0E),
        InvalidDX9ResourceIntel = unchecked((int)0xFFFFFFFFFFFFFC0D),
        DX9ResourceAlreadyAcquiredIntel = unchecked((int)0xFFFFFFFFFFFFFC0C),
        DX9ResourceNotAcquiredIntel = unchecked((int)0xFFFFFFFFFFFFFC0B),
        D3D9DeviceIntel = 0x4022,
        D3D9EXDeviceIntel = 0x4070,
        DxvaDeviceIntel = 0x4071,
        PreferredDevicesForDX9Intel = 0x4024,
        AllDevicesForDX9Intel = 0x4025,
        ContextD3D9DeviceIntel = 0x4026,
        ContextD3D9EXDeviceIntel = 0x4072,
        ContextDxvaDeviceIntel = 0x4073,
        MemDX9ResourceIntel = 0x4027,
        MemDX9SharedHandleIntel = 0x4074,
        ImageDX9PlaneIntel = 0x4075,
        CommandAcquireDX9ObjectsIntel = 0x402A,
        CommandReleaseDX9ObjectsIntel = 0x402B,
        EglYuvPlaneIntel = 0x4107,
        AcceleratorTypeMotionEstimationIntel = 0x0,
        MESubpixelModeIntegerIntel = 0x0,
        MESubpixelModeHpelIntel = 0x1,
        MESubpixelModeQpelIntel = 0x2,
        MESadAdjustModeNoneIntel = 0x0,
        MESadAdjustModeHaarIntel = 0x1,
        MESearchPathRadius22Intel = 0x0,
        MESearchPathRadius44Intel = 0x1,
        MESearchPathRadius1612Intel = 0x5,
        YuyvIntel = 0x4076,
        UyvyIntel = 0x4077,
        YvyuIntel = 0x4078,
        VyuyIntel = 0x4079,
        NV12Intel = 0x410E,
        MemNoAccessIntel = 0x16777216,
        MemAccessFlagsUnrestrictedIntel = 0x33554432,
        DevicePlanarYuvMaxWidthIntel = 0x417E,
        DevicePlanarYuvMaxHeightIntel = 0x417F,
        DeviceSubGroupSizesIntel = 0x4108,
        KernelSpillMemSizeIntel = 0x4109,
        KernelCompileSubGroupSizeIntel = 0x410A,
        DeviceSimultaneousInteropsIntel = 0x4104,
        DeviceNumSimultaneousInteropsIntel = 0x4105,
        QueueThreadLocalExecEnableIntel = unchecked((int)0xFFFFFFFF80000000),
        DeviceHostMemCapabilitiesIntel = 0x4190,
        DeviceDeviceMemCapabilitiesIntel = 0x4191,
        DeviceSingleDeviceSharedMemCapabilitiesIntel = 0x4192,
        DeviceCrossDeviceSharedMemCapabilitiesIntel = 0x4193,
        DeviceSharedSystemMemCapabilitiesIntel = 0x4194,
        UnifiedSharedMemoryAccessIntel = 0x1,
        UnifiedSharedMemoryAtomicAccessIntel = 0x2,
        UnifiedSharedMemoryConcurrentAccessIntel = 0x4,
        UnifiedSharedMemoryConcurrentAtomicAccessIntel = 0x8,
        MemAllocFlagsIntel = 0x4195,
        MemAllocWriteCombinedIntel = 0x1,
        MemAllocTypeIntel = 0x419A,
        MemAllocBasePtrIntel = 0x419B,
        MemAllocSizeIntel = 0x419C,
        MemAllocDeviceIntel = 0x419D,
        MemTypeUnknownIntel = 0x4196,
        MemTypeHostIntel = 0x4197,
        MemTypeDeviceIntel = 0x4198,
        MemTypeSharedIntel = 0x4199,
        KernelExecInfoIndirectHostAccessIntel = 0x4200,
        KernelExecInfoIndirectDeviceAccessIntel = 0x4201,
        KernelExecInfoIndirectSharedAccessIntel = 0x4202,
        KernelExecInfoUsmPtrsIntel = 0x4203,
        CommandMemfillIntel = 0x4204,
        CommandMemcpyIntel = 0x4205,
        CommandMigratememIntel = 0x4206,
        CommandMemadviseIntel = 0x4207,
        MigrateMemObjectHostIntel = 0x1,
        MigrateMemObjectContentUndefinedIntel = 0x2,
        InvalidVAApiMediaAdapterIntel = unchecked((int)0xFFFFFFFFFFFFFBB6),
        InvalidVAApiMediaSurfaceIntel = unchecked((int)0xFFFFFFFFFFFFFBB5),
        VAApiMediaSurfaceAlreadyAcquiredIntel = unchecked((int)0xFFFFFFFFFFFFFBB4),
        VAApiMediaSurfaceNotAcquiredIntel = unchecked((int)0xFFFFFFFFFFFFFBB3),
        VAApiDisplayIntel = 0x4094,
        PreferredDevicesForVAApiIntel = 0x4095,
        AllDevicesForVAApiIntel = 0x4096,
        ContextVAApiDisplayIntel = 0x4097,
        MemVAApiMediaSurfaceIntel = 0x4098,
        ImageVAApiPlaneIntel = 0x4099,
        CommandAcquireVAApiMediaSurfacesIntel = 0x409A,
        CommandReleaseVAApiMediaSurfacesIntel = 0x409B,
    }
}

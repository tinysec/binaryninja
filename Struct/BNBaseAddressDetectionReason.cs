using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNBaseAddressDetectionReason 
	{
		/// <summary>
		/// uint64_t Pointer
		/// </summary>
		public ulong Pointer;
		
		/// <summary>
		/// uint64_t POIOffset
		/// </summary>
		public ulong POIOffset;
		
		/// <summary>
		/// BNBaseAddressDetectionPOIType POIType
		/// </summary>
		public BaseAddressDetectionPOIType POIType;
		
	}

    public sealed class BaseAddressDetectionReason 
    {
		public ulong Pointer { get; set; } = 0;
		
		public ulong POIOffset { get; set; } = 0;

		public BaseAddressDetectionPOIType POIType { get; set; } = BaseAddressDetectionPOIType.POIString;
		
		public BaseAddressDetectionReason() 
		{
		    
		}
    }
}
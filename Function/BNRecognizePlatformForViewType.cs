using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNPlatform* BNRecognizePlatformForViewType(BNBinaryViewType* type, uint64_t id, BNEndianness endian, BNBinaryView* view, BNMetadata* metadata)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNRecognizePlatformForViewType"
        )]
		internal static extern IntPtr BNRecognizePlatformForViewType(
			
			// BNBinaryViewType* type
		    IntPtr type  , 
			
			// uint64_t id
		    ulong id  , 
			
			// BNEndianness endian
		    Endianness endian  , 
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNMetadata* metadata
		    IntPtr metadata  
		);
	}
}
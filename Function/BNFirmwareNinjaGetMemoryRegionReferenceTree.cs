using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNFirmwareNinjaReferenceNode* BNFirmwareNinjaGetMemoryRegionReferenceTree(BNFirmwareNinja* fn, uint64_t start, uint64_t end, BNFirmwareNinjaFunctionMemoryAccesses** fma, int32_t size, uint64_t* value)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFirmwareNinjaGetMemoryRegionReferenceTree"
        )]
		internal static extern IntPtr BNFirmwareNinjaGetMemoryRegionReferenceTree(
			
			// BNFirmwareNinja* fn
		    IntPtr fn  , 
			
			// uint64_t start
		    ulong start  , 
			
			// uint64_t end
		    ulong end  , 
			
			// BNFirmwareNinjaFunctionMemoryAccesses** fma
		    IntPtr fma  , 
			
			// int32_t size
		    int size  , 
			
			// uint64_t* _value
		    IntPtr _value  
			
		);
	}
}
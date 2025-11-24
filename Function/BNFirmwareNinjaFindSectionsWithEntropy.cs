using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// int32_t BNFirmwareNinjaFindSectionsWithEntropy(BNFirmwareNinja* fn, BNFirmwareNinjaSection** sections, float highCodeEntropyThreshold, float lowCodeEntropyThreshold, uint64_t blockSize, BNFirmwareNinjaSectionAnalysisMode mode)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFirmwareNinjaFindSectionsWithEntropy"
        )]
		internal static extern int BNFirmwareNinjaFindSectionsWithEntropy(
			
			// BNFirmwareNinja* fn
		    IntPtr fn  , 
			
			// BNFirmwareNinjaSection** sections
		    IntPtr sections  , 
			
			// float highCodeEntropyThreshold
		    float highCodeEntropyThreshold  , 
			
			// float lowCodeEntropyThreshold
		    float lowCodeEntropyThreshold  , 
			
			// uint64_t blockSize
		    ulong blockSize  , 
			
			// BNFirmwareNinjaSectionAnalysisMode mode
		    FirmwareNinjaSectionAnalysisMode mode  
			
		);
	}
}
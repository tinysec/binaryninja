using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetBaseAddressDetectionScores(BNBaseAddressDetection* bad, BNBaseAddressDetectionScore* scores, uint64_t count, BNBaseAddressDetectionConfidence* confidence, uint64_t* lastTestedBaseAddress)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetBaseAddressDetectionScores"
        )]
		internal static extern ulong BNGetBaseAddressDetectionScores(
			
			// BNBaseAddressDetection* bad
		    IntPtr bad  , 
			
			// BNBaseAddressDetectionScore* scores
		    IntPtr scores  , 
			
			// uint64_t count
		    ulong count  , 
			
			// BNBaseAddressDetectionConfidence* confidence
		    IntPtr confidence  , 
			
			// uint64_t* lastTestedBaseAddress
		    IntPtr lastTestedBaseAddress  
			
		);
	}
}
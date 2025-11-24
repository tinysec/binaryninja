using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeAnalysisPerformanceInfo(BNPerformanceInfo* info, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeAnalysisPerformanceInfo"
        )]
		internal static extern void BNFreeAnalysisPerformanceInfo(
			
			// BNPerformanceInfo* info
		    IntPtr info  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}
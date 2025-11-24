using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeAnalysisInfo(BNAnalysisInfo* info)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeAnalysisInfo"
        )]
		internal static extern void BNFreeAnalysisInfo(
			
			// BNAnalysisInfo* info
		    IntPtr info  
		);
	}
}
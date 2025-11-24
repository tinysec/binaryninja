using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetMaxFunctionSizeForAnalysis(BNBinaryView* view, uint64_t size)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetMaxFunctionSizeForAnalysis"
        )]
		internal static extern void BNSetMaxFunctionSizeForAnalysis(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// uint64_t size
		    ulong size  
		);
	}
}
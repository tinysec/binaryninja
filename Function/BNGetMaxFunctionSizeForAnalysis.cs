using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetMaxFunctionSizeForAnalysis(BNBinaryView* view)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetMaxFunctionSizeForAnalysis"
        )]
		internal static extern ulong BNGetMaxFunctionSizeForAnalysis(
			
			// BNBinaryView* view
		    IntPtr view  
		);
	}
}
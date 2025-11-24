using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNReleaseAdvancedFunctionAnalysisDataMultiple(BNFunction* func, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNReleaseAdvancedFunctionAnalysisDataMultiple"
        )]
		internal static extern void BNReleaseAdvancedFunctionAnalysisDataMultiple(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}
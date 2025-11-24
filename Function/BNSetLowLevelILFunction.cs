using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetLowLevelILFunction(BNAnalysisContext* analysisContext, BNLowLevelILFunction* lowLevelIL)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetLowLevelILFunction"
        )]
		internal static extern void BNSetLowLevelILFunction(
			
			// BNAnalysisContext* analysisContext
		    IntPtr analysisContext  , 
			
			// BNLowLevelILFunction* lowLevelIL
		    IntPtr lowLevelIL  
			
		);
	}
}
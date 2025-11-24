using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetLiftedILFunction(BNAnalysisContext* analysisContext, BNLowLevelILFunction* liftedIL)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetLiftedILFunction"
        )]
		internal static extern void BNSetLiftedILFunction(
			
			// BNAnalysisContext* analysisContext
		    IntPtr analysisContext  , 
			
			// BNLowLevelILFunction* liftedIL
		    IntPtr liftedIL  
			
		);
	}
}
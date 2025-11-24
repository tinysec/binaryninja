using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetHighLevelILFunction(BNAnalysisContext* analysisContext, BNHighLevelILFunction* highLevelIL)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetHighLevelILFunction"
        )]
		internal static extern void BNSetHighLevelILFunction(
			
			// BNAnalysisContext* analysisContext
		    IntPtr analysisContext  , 
			
			// BNHighLevelILFunction* highLevelIL
		    IntPtr highLevelIL  
			
		);
	}
}
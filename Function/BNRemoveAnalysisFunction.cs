using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNRemoveAnalysisFunction(BNBinaryView* view, BNFunction* func, bool updateRefs)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNRemoveAnalysisFunction"
        )]
		internal static extern void BNRemoveAnalysisFunction(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNFunction* func
		    IntPtr func  , 
			
			// bool updateRefs
		    bool updateRefs  
		);
	}
}
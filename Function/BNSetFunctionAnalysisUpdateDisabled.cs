using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetFunctionAnalysisUpdateDisabled(BNBinaryView* view, bool disabled)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetFunctionAnalysisUpdateDisabled"
        )]
		internal static extern void BNSetFunctionAnalysisUpdateDisabled(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// bool disabled
		    bool disabled  
		);
	}
}
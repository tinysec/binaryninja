using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetNewAutoFunctionAnalysisSuppressed(BNBinaryView* view, bool suppress)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetNewAutoFunctionAnalysisSuppressed"
        )]
		internal static extern void BNSetNewAutoFunctionAnalysisSuppressed(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// bool suppress
		    bool suppress  
		);
	}
}
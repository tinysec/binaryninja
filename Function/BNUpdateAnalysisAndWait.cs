using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNUpdateAnalysisAndWait(BNBinaryView* view)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNUpdateAnalysisAndWait"
        )]
		internal static extern void BNUpdateAnalysisAndWait(
			
			// BNBinaryView* view
		    IntPtr view  
		);
	}
}
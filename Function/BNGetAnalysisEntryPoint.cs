using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNFunction* BNGetAnalysisEntryPoint(BNBinaryView* view)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetAnalysisEntryPoint"
        )]
		internal static extern IntPtr BNGetAnalysisEntryPoint(
			
			// BNBinaryView* view
		    IntPtr view  
			
		);
	}
}
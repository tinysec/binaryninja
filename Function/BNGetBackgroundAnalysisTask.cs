using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNBackgroundTask* BNGetBackgroundAnalysisTask(BNBinaryView* view)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetBackgroundAnalysisTask"
        )]
		internal static extern IntPtr BNGetBackgroundAnalysisTask(
			
			// BNBinaryView* view
		    IntPtr view  
			
		);
	}
}
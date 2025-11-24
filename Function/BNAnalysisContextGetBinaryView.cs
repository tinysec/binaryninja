using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNBinaryView* BNAnalysisContextGetBinaryView(BNAnalysisContext* analysisContext)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAnalysisContextGetBinaryView"
        )]
		internal static extern IntPtr BNAnalysisContextGetBinaryView(
			
			// BNAnalysisContext* analysisContext
		    IntPtr analysisContext  
		);
	}
}
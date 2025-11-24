using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNAnalysisCompletionEvent* BNAddAnalysisCompletionEvent(BNBinaryView* view, void* ctxt, void** callback)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAddAnalysisCompletionEvent"
        )]
		internal static extern IntPtr BNAddAnalysisCompletionEvent(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// void* ctxt
		    IntPtr ctxt  , 
			
			// void** callback
		    IntPtr callback  
		);
	}
}
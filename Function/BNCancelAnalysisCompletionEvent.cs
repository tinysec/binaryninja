using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNCancelAnalysisCompletionEvent(BNAnalysisCompletionEvent* @event)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCancelAnalysisCompletionEvent"
        )]
		internal static extern void BNCancelAnalysisCompletionEvent(
			
			// BNAnalysisCompletionEvent* _event
		    IntPtr _event  
		);
	}
}
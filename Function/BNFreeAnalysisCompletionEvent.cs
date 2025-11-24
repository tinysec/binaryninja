using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeAnalysisCompletionEvent(BNAnalysisCompletionEvent* @event)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeAnalysisCompletionEvent"
        )]
		internal static extern void BNFreeAnalysisCompletionEvent(
			
			// BNAnalysisCompletionEvent* _event
		    IntPtr _event  
			
		);
	}
}
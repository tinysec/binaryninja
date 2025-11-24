using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNAnalysisCompletionEvent* BNNewAnalysisCompletionEventReference(BNAnalysisCompletionEvent* @event)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNNewAnalysisCompletionEventReference"
        )]
		internal static extern IntPtr BNNewAnalysisCompletionEventReference(
			
			// BNAnalysisCompletionEvent* _event
		    IntPtr _event  
		);
	}
}
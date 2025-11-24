using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// char* BNUndoActionGetSummaryText(BNUndoAction* action)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNUndoActionGetSummaryText"
        )]
		internal static extern IntPtr BNUndoActionGetSummaryText(
			
			// BNUndoAction* action
		    IntPtr action  
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNUndoAction* BNNewUndoActionReference(BNUndoAction* action)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNNewUndoActionReference"
        )]
		internal static extern IntPtr BNNewUndoActionReference(
			
			// BNUndoAction* action
		    IntPtr action  
		);
	}
}
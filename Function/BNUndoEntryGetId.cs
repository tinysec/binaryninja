using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNUndoEntryGetId(BNUndoEntry* entry)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNUndoEntryGetId"
        )]
		internal static extern IntPtr BNUndoEntryGetId(
			
			// BNUndoEntry* entry
		    IntPtr entry  
			
		);
	}
}
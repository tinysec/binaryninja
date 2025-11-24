using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeUndoEntry(BNUndoEntry* entry)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeUndoEntry"
        )]
		internal static extern void BNFreeUndoEntry(
			
			// BNUndoEntry* entry
		    IntPtr entry  
			
		);
	}
}
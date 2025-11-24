using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeUndoEntries(BNUndoEntry** entries, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeUndoEntries"
        )]
		internal static extern void BNFreeUndoEntries(
			
			// BNUndoEntry** entries
		    IntPtr entries  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}
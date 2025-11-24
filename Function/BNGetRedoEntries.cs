using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNUndoEntry** BNGetRedoEntries(BNFileMetadata* file, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetRedoEntries"
        )]
		internal static extern IntPtr BNGetRedoEntries(
			
			// BNFileMetadata* file
		    IntPtr file  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
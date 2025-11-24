using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNUndoEntry* BNGetLastRedoEntry(BNFileMetadata* file)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetLastRedoEntry"
        )]
		internal static extern IntPtr BNGetLastRedoEntry(
			
			// BNFileMetadata* file
		    IntPtr file  
			
		);
	}
}
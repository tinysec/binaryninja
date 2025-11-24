using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNGetLastUndoEntryTitle(BNFileMetadata* file)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetLastUndoEntryTitle"
        )]
		internal static extern IntPtr BNGetLastUndoEntryTitle(
			
			// BNFileMetadata* file
		    IntPtr file  
			
		);
	}
}
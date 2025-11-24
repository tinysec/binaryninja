using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeTypeArchiveMergeConflictList(BNTypeArchiveMergeConflict** conflicts, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeTypeArchiveMergeConflictList"
        )]
		internal static extern void BNFreeTypeArchiveMergeConflictList(
			
			// BNTypeArchiveMergeConflict** conflicts
		    IntPtr conflicts  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}
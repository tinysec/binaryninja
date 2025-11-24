using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeUndoActionList(BNUndoAction** actions, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeUndoActionList"
        )]
		internal static extern void BNFreeUndoActionList(
			
			// BNUndoAction** actions
		    IntPtr actions  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}
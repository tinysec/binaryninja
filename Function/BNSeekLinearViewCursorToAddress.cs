using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSeekLinearViewCursorToAddress(BNLinearViewCursor* cursor, uint64_t addr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSeekLinearViewCursorToAddress"
        )]
		internal static extern void BNSeekLinearViewCursorToAddress(
			
			// BNLinearViewCursor* cursor
		    IntPtr cursor  , 
			
			// uint64_t addr
		    ulong addr  
		);
	}
}
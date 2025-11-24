using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSeekLinearViewCursorToOrderingIndex(BNLinearViewCursor* cursor, uint64_t idx)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSeekLinearViewCursorToOrderingIndex"
        )]
		internal static extern void BNSeekLinearViewCursorToOrderingIndex(
			
			// BNLinearViewCursor* cursor
		    IntPtr cursor  , 
			
			// uint64_t idx
		    ulong idx  
		);
	}
}
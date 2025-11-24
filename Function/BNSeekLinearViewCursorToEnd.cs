using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSeekLinearViewCursorToEnd(BNLinearViewCursor* cursor)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSeekLinearViewCursorToEnd"
        )]
		internal static extern void BNSeekLinearViewCursorToEnd(
			
			// BNLinearViewCursor* cursor
		    IntPtr cursor  
		);
	}
}
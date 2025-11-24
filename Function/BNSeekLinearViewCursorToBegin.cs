using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSeekLinearViewCursorToBegin(BNLinearViewCursor* cursor)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSeekLinearViewCursorToBegin"
        )]
		internal static extern void BNSeekLinearViewCursorToBegin(
			
			// BNLinearViewCursor* cursor
		    IntPtr cursor  
		);
	}
}
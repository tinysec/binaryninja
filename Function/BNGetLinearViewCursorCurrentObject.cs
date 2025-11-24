using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLinearViewObject* BNGetLinearViewCursorCurrentObject(BNLinearViewCursor* cursor)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetLinearViewCursorCurrentObject"
        )]
		internal static extern IntPtr BNGetLinearViewCursorCurrentObject(
			
			// BNLinearViewCursor* cursor
		    IntPtr cursor  
			
		);
	}
}
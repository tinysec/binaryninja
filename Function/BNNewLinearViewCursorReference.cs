using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLinearViewCursor* BNNewLinearViewCursorReference(BNLinearViewCursor* cursor)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewLinearViewCursorReference"
        )]
		internal static extern IntPtr BNNewLinearViewCursorReference(
			
			// BNLinearViewCursor* cursor
		    IntPtr cursor  
			
		);
	}
}
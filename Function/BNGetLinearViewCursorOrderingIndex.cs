using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNAddressRange BNGetLinearViewCursorOrderingIndex(BNLinearViewCursor* cursor)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLinearViewCursorOrderingIndex"
        )]
		internal static extern BNAddressRange BNGetLinearViewCursorOrderingIndex(
			
			// BNLinearViewCursor* cursor
		    IntPtr cursor  
		);
	}
}
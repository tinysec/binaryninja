using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetLinearViewCursorOrderingIndexTotal(BNLinearViewCursor* cursor)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLinearViewCursorOrderingIndexTotal"
        )]
		internal static extern ulong BNGetLinearViewCursorOrderingIndexTotal(
			
			// BNLinearViewCursor* cursor
		    IntPtr cursor  
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLinearViewCursor* BNDuplicateLinearViewCursor(BNLinearViewCursor* cursor)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNDuplicateLinearViewCursor"
        )]
		internal static extern IntPtr BNDuplicateLinearViewCursor(
			
			// BNLinearViewCursor* cursor
		    IntPtr cursor  
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeLinearViewCursor(BNLinearViewCursor* cursor)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeLinearViewCursor"
        )]
		internal static extern void BNFreeLinearViewCursor(
			
			// BNLinearViewCursor* cursor
		    IntPtr cursor  
			
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLinearViewObjectIdentifier* BNGetLinearViewCursorPath(BNLinearViewCursor* cursor, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLinearViewCursorPath"
        )]
		internal static extern IntPtr BNGetLinearViewCursorPath(
			
			// BNLinearViewCursor* cursor
		    IntPtr cursor  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
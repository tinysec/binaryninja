using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// int32_t BNCompareLinearViewCursors(BNLinearViewCursor* a, BNLinearViewCursor* b)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCompareLinearViewCursors"
        )]
		internal static extern int BNCompareLinearViewCursors(
			
			// BNLinearViewCursor* a
		    IntPtr a  , 
			
			// BNLinearViewCursor* b
		    IntPtr b  
		);
	}
}
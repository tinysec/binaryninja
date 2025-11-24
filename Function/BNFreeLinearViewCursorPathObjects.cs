using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeLinearViewCursorPathObjects(BNLinearViewObject** objs, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeLinearViewCursorPathObjects"
        )]
		internal static extern void BNFreeLinearViewCursorPathObjects(
			
			// BNLinearViewObject** objs
		    IntPtr objs  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}
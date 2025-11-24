using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeLinearViewObject(BNLinearViewObject* obj)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeLinearViewObject"
        )]
		internal static extern void BNFreeLinearViewObject(
			
			// BNLinearViewObject* obj
		    IntPtr obj  
			
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLinearViewCursor* BNCreateLinearViewCursor(BNLinearViewObject* root)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateLinearViewCursor"
        )]
		internal static extern IntPtr BNCreateLinearViewCursor(
			
			// BNLinearViewObject* root
		    IntPtr root  
		);
	}
}
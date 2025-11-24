using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// char* BNGetTransformName(BNTransform* xform)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetTransformName"
        )]
		internal static extern IntPtr BNGetTransformName(
			
			// BNTransform* xform
		    IntPtr xform  
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// char* BNGetTransformLongName(BNTransform* xform)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetTransformLongName"
        )]
		internal static extern IntPtr BNGetTransformLongName(
			
			// BNTransform* xform
		    IntPtr xform  
		);
	}
}
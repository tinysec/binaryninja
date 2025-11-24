using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// char* BNGetTransformGroup(BNTransform* xform)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetTransformGroup"
        )]
		internal static extern IntPtr BNGetTransformGroup(
			
			// BNTransform* xform
		    IntPtr xform  
		);
	}
}
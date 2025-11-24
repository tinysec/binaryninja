using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTransformType BNGetTransformType(BNTransform* xform)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetTransformType"
        )]
		internal static extern TransformType BNGetTransformType(
			
			// BNTransform* xform
		    IntPtr xform  
		);
	}
}
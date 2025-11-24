using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTransformContext* BNTransformContextGetParent(BNTransformContext* context)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNTransformContextGetParent"
        )]
		internal static extern IntPtr BNTransformContextGetParent(
			
			// BNTransformContext* context
		    IntPtr context  
		);
	}
}
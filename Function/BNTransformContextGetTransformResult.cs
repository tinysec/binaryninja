using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTransformResult BNTransformContextGetTransformResult(BNTransformContext* context)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNTransformContextGetTransformResult"
        )]
		internal static extern TransformResult BNTransformContextGetTransformResult(
			
			// BNTransformContext* context
		    IntPtr context  
		);
	}
}
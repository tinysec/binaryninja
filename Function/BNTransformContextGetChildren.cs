using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTransformContext** BNTransformContextGetChildren(BNTransformContext* context, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNTransformContextGetChildren"
        )]
		internal static extern IntPtr BNTransformContextGetChildren(
			
			// BNTransformContext* context
		    IntPtr context  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
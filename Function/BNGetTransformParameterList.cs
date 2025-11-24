using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTransformParameterInfo* BNGetTransformParameterList(BNTransform* xform, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetTransformParameterList"
        )]
		internal static extern IntPtr BNGetTransformParameterList(
			
			// BNTransform* xform
		    IntPtr xform  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
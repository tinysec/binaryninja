using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeTransformTypeList(BNTransform** xforms)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeTransformTypeList"
        )]
		internal static extern void BNFreeTransformTypeList(
			
			// BNTransform** xforms
		    IntPtr xforms  
		);
	}
}
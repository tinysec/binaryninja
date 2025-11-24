using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNPointerBaseType BNTypeGetPointerBaseType(BNType* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNTypeGetPointerBaseType"
        )]
		internal static extern PointerBaseType BNTypeGetPointerBaseType(
			
			// BNType* type
		    IntPtr type  
		);
	}
}
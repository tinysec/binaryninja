using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNIntegerDisplayType BNGetIntegerTypeDisplayType(BNType* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetIntegerTypeDisplayType"
        )]
		internal static extern IntegerDisplayType BNGetIntegerTypeDisplayType(
			
			// BNType* type
		    IntPtr type  
		);
	}
}
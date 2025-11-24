using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNReferenceType BNTypeGetReferenceType(BNType* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNTypeGetReferenceType"
        )]
		internal static extern ReferenceType BNTypeGetReferenceType(
			
			// BNType* type
		    IntPtr type  
			
		);
	}
}
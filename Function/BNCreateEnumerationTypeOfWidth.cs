using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNType* BNCreateEnumerationTypeOfWidth(BNEnumeration* e, uint64_t width, BNBoolWithConfidence* isSigned)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateEnumerationTypeOfWidth"
        )]
		internal static extern IntPtr BNCreateEnumerationTypeOfWidth(
			
			// BNEnumeration* e
		    IntPtr e  , 
			
			// uint64_t width
		    ulong width  , 
			
			// BNBoolWithConfidence* isSigned
		    in BNBoolWithConfidence isSigned  
		);
	}
}
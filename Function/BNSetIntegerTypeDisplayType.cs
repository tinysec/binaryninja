using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetIntegerTypeDisplayType(BNTypeBuilder* type, BNIntegerDisplayType displayType)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetIntegerTypeDisplayType"
        )]
		internal static extern void BNSetIntegerTypeDisplayType(
			
			// BNTypeBuilder* type
		    IntPtr type  , 
			
			// BNIntegerDisplayType displayType
		    IntegerDisplayType displayType  
			
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetTypeBuilderNameType(BNTypeBuilder* type, BNNameType nameType)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetTypeBuilderNameType"
        )]
		internal static extern void BNSetTypeBuilderNameType(
			
			// BNTypeBuilder* type
		    IntPtr type  , 
			
			// BNNameType nameType
		    NameType nameType  
			
		);
	}
}
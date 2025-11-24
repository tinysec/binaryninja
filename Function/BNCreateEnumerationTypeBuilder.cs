using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTypeBuilder* BNCreateEnumerationTypeBuilder(BNArchitecture* arch, BNEnumeration* e, uint64_t width, BNBoolWithConfidence* isSigned)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateEnumerationTypeBuilder"
        )]
		internal static extern IntPtr BNCreateEnumerationTypeBuilder(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// BNEnumeration* e
		    IntPtr e  , 
			
			// uint64_t width
		    ulong width  , 
			
			// BNBoolWithConfidence* isSigned
		    IntPtr isSigned  
		);
	}
}
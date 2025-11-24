using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTypeBuilder* BNCreateEnumerationTypeBuilderWithBuilder(BNArchitecture* arch, BNEnumerationBuilder* e, uint64_t width, BNBoolWithConfidence* isSigned)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateEnumerationTypeBuilderWithBuilder"
        )]
		internal static extern IntPtr BNCreateEnumerationTypeBuilderWithBuilder(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// BNEnumerationBuilder* e
		    IntPtr e  , 
			
			// uint64_t width
		    ulong width  , 
			
			// BNBoolWithConfidence* isSigned
		    IntPtr isSigned  
		);
	}
}
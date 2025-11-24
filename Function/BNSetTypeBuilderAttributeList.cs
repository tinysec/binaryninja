using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetTypeBuilderAttributeList(BNTypeBuilder* type, BNTypeAttribute* attrs, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetTypeBuilderAttributeList"
        )]
		internal static extern void BNSetTypeBuilderAttributeList(
			
			// BNTypeBuilder* type
		    IntPtr type  , 
			
			// BNTypeAttribute* attrs
		    IntPtr attrs  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}
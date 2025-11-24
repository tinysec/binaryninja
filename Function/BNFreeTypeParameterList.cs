using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeTypeParameterList(BNFunctionParameter* types, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeTypeParameterList"
        )]
		internal static extern void BNFreeTypeParameterList(
			
			// BNFunctionParameter* types
		    IntPtr types  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}
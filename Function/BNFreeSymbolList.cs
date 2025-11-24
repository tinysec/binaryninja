using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeSymbolList(BNSymbol** syms, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeSymbolList"
        )]
		internal static extern void BNFreeSymbolList(
			
			// BNSymbol** syms
		    IntPtr syms  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}
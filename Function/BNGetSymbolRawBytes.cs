using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void* BNGetSymbolRawBytes(BNSymbol* sym, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetSymbolRawBytes"
        )]
		internal static extern IntPtr BNGetSymbolRawBytes(
			
			// BNSymbol* sym
		    IntPtr sym  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
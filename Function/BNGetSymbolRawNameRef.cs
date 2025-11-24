using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNStringRef* BNGetSymbolRawNameRef(BNSymbol* sym)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetSymbolRawNameRef"
        )]
		internal static extern IntPtr BNGetSymbolRawNameRef(
			
			// BNSymbol* sym
		    IntPtr sym  
			
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNStringRef* BNGetSymbolShortNameRef(BNSymbol* sym)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetSymbolShortNameRef"
        )]
		internal static extern IntPtr BNGetSymbolShortNameRef(
			
			// BNSymbol* sym
		    IntPtr sym  
			
		);
	}
}
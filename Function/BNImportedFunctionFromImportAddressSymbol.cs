using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNSymbol* BNImportedFunctionFromImportAddressSymbol(BNSymbol* sym, uint64_t addr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNImportedFunctionFromImportAddressSymbol"
        )]
		internal static extern IntPtr BNImportedFunctionFromImportAddressSymbol(
			
			// BNSymbol* sym
		    IntPtr sym  , 
			
			// uint64_t addr
		    ulong addr  
			
		);
	}
}
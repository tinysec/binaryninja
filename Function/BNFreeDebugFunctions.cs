using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeDebugFunctions(BNDebugFunctionInfo* functions, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeDebugFunctions"
        )]
		internal static extern void BNFreeDebugFunctions(
			
			// BNDebugFunctionInfo* functions
		    IntPtr functions  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}
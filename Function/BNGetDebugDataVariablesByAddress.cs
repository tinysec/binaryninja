using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDataVariableAndNameAndDebugParser* BNGetDebugDataVariablesByAddress(BNDebugInfo* debugInfo, uint64_t address, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetDebugDataVariablesByAddress"
        )]
		internal static extern IntPtr BNGetDebugDataVariablesByAddress(
			
			// BNDebugInfo* debugInfo
		    IntPtr debugInfo  , 
			
			// uint64_t address
		    ulong address  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}
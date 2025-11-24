using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeDataVariableAndNameAndDebugParserList(BNDataVariableAndNameAndDebugParser* vars, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeDataVariableAndNameAndDebugParserList"
        )]
		internal static extern void BNFreeDataVariableAndNameAndDebugParserList(
			
			// BNDataVariableAndNameAndDebugParser* vars
		    IntPtr vars  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}
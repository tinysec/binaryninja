using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeDataVariables(BNDataVariable* vars, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeDataVariables"
        )]
		internal static extern void BNFreeDataVariables(
			
			// BNDataVariable* vars
		    IntPtr vars  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}
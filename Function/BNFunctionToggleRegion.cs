using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFunctionToggleRegion(BNFunction* func, uint64_t hash)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFunctionToggleRegion"
        )]
		internal static extern void BNFunctionToggleRegion(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// uint64_t hash
		    ulong hash  
			
		);
	}
}
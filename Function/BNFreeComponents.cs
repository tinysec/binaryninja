using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeComponents(BNComponent** components, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeComponents"
        )]
		internal static extern void BNFreeComponents(
			
			// BNComponent** components
		    IntPtr components  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}
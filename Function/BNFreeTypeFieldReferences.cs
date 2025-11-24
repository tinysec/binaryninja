using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeTypeFieldReferences(BNTypeFieldReference* refs, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeTypeFieldReferences"
        )]
		internal static extern void BNFreeTypeFieldReferences(
			
			// BNTypeFieldReference* refs
		    IntPtr refs  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}
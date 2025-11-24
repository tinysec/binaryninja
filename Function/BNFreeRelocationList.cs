using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeRelocationList(BNRelocation** relocations, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeRelocationList"
        )]
		internal static extern void BNFreeRelocationList(
			
			// BNRelocation** relocations
		    IntPtr relocations  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetDisassemblyAddressBaseOffset(BNDisassemblySettings* settings, uint64_t addressBaseOffset)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetDisassemblyAddressBaseOffset"
        )]
		internal static extern void BNSetDisassemblyAddressBaseOffset(
			
			// BNDisassemblySettings* settings
		    IntPtr settings  , 
			
			// uint64_t addressBaseOffset
		    ulong addressBaseOffset  
			
		);
	}
}
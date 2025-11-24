using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeBaseStructureList(BNBaseStructure* bases, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeBaseStructureList"
        )]
		internal static extern void BNFreeBaseStructureList(
			
			// BNBaseStructure* bases
		    IntPtr bases  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}
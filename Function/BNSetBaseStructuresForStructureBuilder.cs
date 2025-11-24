using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetBaseStructuresForStructureBuilder(BNStructureBuilder* s, BNBaseStructure* bases, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetBaseStructuresForStructureBuilder"
        )]
		internal static extern void BNSetBaseStructuresForStructureBuilder(
			
			// BNStructureBuilder* s
		    IntPtr s  , 
			
			// BNBaseStructure* bases
			BNBaseStructure[] bases  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}
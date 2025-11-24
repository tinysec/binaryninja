using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNBaseStructure* BNGetBaseStructuresForStructure(BNStructure* s, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetBaseStructuresForStructure"
        )]
		internal static extern IntPtr BNGetBaseStructuresForStructure(
			
			// BNStructure* s
		    IntPtr s  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
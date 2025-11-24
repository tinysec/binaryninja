using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeLinearDisassemblyLines(BNLinearDisassemblyLine* lines, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeLinearDisassemblyLines"
        )]
		internal static extern void BNFreeLinearDisassemblyLines(
			
			// BNLinearDisassemblyLine* lines
		    IntPtr lines  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}
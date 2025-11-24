using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeDisassemblyTextLines(BNDisassemblyTextLine* lines, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeDisassemblyTextLines"
        )]
		internal static extern void BNFreeDisassemblyTextLines(
			
			// BNDisassemblyTextLine* lines
		    IntPtr lines  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}
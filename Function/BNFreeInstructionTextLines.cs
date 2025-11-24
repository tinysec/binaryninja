using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeInstructionTextLines(BNInstructionTextLine* lines, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeInstructionTextLines"
        )]
		internal static extern void BNFreeInstructionTextLines(
			
			// BNInstructionTextLine* lines
		    IntPtr lines  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}
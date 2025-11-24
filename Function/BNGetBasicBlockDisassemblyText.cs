using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDisassemblyTextLine* BNGetBasicBlockDisassemblyText(BNBasicBlock* block, BNDisassemblySettings* settings, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetBasicBlockDisassemblyText"
        )]
		internal static extern IntPtr BNGetBasicBlockDisassemblyText(
			
			// BNBasicBlock* block
		    IntPtr block  , 
			
			// BNDisassemblySettings* settings
		    IntPtr settings  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
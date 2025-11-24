using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetDisassemblyTextRendererBasicBlock(BNDisassemblyTextRenderer* renderer, BNBasicBlock* block)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetDisassemblyTextRendererBasicBlock"
        )]
		internal static extern void BNSetDisassemblyTextRendererBasicBlock(
			
			// BNDisassemblyTextRenderer* renderer
		    IntPtr renderer  , 
			
			// BNBasicBlock* block
		    IntPtr block  
			
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNBasicBlock* BNGetDisassemblyTextRendererBasicBlock(BNDisassemblyTextRenderer* renderer)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetDisassemblyTextRendererBasicBlock"
        )]
		internal static extern IntPtr BNGetDisassemblyTextRendererBasicBlock(
			
			// BNDisassemblyTextRenderer* renderer
		    IntPtr renderer  
			
		);
	}
}
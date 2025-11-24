using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLowLevelILFunction* BNGetDisassemblyTextRendererLowLevelILFunction(BNDisassemblyTextRenderer* renderer)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetDisassemblyTextRendererLowLevelILFunction"
        )]
		internal static extern IntPtr BNGetDisassemblyTextRendererLowLevelILFunction(
			
			// BNDisassemblyTextRenderer* renderer
		    IntPtr renderer  
			
		);
	}
}
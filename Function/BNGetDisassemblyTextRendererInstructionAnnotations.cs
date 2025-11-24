using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNInstructionTextToken* BNGetDisassemblyTextRendererInstructionAnnotations(BNDisassemblyTextRenderer* renderer, uint64_t addr, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetDisassemblyTextRendererInstructionAnnotations"
        )]
		internal static extern IntPtr BNGetDisassemblyTextRendererInstructionAnnotations(
			
			// BNDisassemblyTextRenderer* renderer
		    IntPtr renderer  , 
			
			// uint64_t addr
		    ulong addr  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}
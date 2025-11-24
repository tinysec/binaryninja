using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNInstructionTextToken* BNGetDisassemblyTextRendererIntegerTokens(BNDisassemblyTextRenderer* renderer, BNInstructionTextToken* token, BNArchitecture* arch, uint64_t addr, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetDisassemblyTextRendererIntegerTokens"
        )]
		internal static extern IntPtr BNGetDisassemblyTextRendererIntegerTokens(
			
			// BNDisassemblyTextRenderer* renderer
		    IntPtr renderer  , 
			
			// BNInstructionTextToken* token
		    IntPtr token  , 
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint64_t addr
		    ulong addr  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}
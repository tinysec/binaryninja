using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNInstructionTextToken* BNGetDisassemblyTextRendererStackVariableReferenceTokens(BNDisassemblyTextRenderer* renderer, BNStackVariableReference* @ref, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetDisassemblyTextRendererStackVariableReferenceTokens"
        )]
		internal static extern IntPtr BNGetDisassemblyTextRendererStackVariableReferenceTokens(
			
			// BNDisassemblyTextRenderer* renderer
		    IntPtr renderer  , 
			
			// BNStackVariableReference* _ref
		    IntPtr _ref  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}
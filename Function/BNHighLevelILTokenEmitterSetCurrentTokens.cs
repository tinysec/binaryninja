using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNHighLevelILTokenEmitterSetCurrentTokens(BNHighLevelILTokenEmitter* emitter, BNInstructionTextToken* tokens, uint64_t tokenCount)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNHighLevelILTokenEmitterSetCurrentTokens"
        )]
		internal static extern void BNHighLevelILTokenEmitterSetCurrentTokens(
			
			// BNHighLevelILTokenEmitter* emitter
		    IntPtr emitter  , 
			
			// BNInstructionTextToken* tokens
		    IntPtr tokens  , 
			
			// uint64_t tokenCount
		    ulong tokenCount  
			
		);
	}
}
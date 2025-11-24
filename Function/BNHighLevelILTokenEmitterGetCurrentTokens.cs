using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNInstructionTextToken* BNHighLevelILTokenEmitterGetCurrentTokens(BNHighLevelILTokenEmitter* emitter, uint64_t* tokenCount)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNHighLevelILTokenEmitterGetCurrentTokens"
        )]
		internal static extern IntPtr BNHighLevelILTokenEmitterGetCurrentTokens(
			
			// BNHighLevelILTokenEmitter* emitter
		    IntPtr emitter  , 
			
			// uint64_t* tokenCount
		    IntPtr tokenCount  
			
		);
	}
}
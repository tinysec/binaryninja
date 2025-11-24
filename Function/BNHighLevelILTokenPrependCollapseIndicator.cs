using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNHighLevelILTokenPrependCollapseIndicator(BNHighLevelILTokenEmitter* emitter, BNInstructionTextTokenContext context, uint64_t hash)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNHighLevelILTokenPrependCollapseIndicator"
        )]
		internal static extern void BNHighLevelILTokenPrependCollapseIndicator(
			
			// BNHighLevelILTokenEmitter* emitter
		    IntPtr emitter  , 
			
			// BNInstructionTextTokenContext context
		    InstructionTextTokenContext context  , 
			
			// uint64_t hash
		    ulong hash  
		);
	}
}
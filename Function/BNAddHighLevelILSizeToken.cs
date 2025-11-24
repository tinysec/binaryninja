using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNAddHighLevelILSizeToken(uint64_t size, BNInstructionTextTokenType type, BNHighLevelILTokenEmitter* tokens)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAddHighLevelILSizeToken"
        )]
		internal static extern void BNAddHighLevelILSizeToken(
			
			// uint64_t size
		    ulong size  , 
			
			// BNInstructionTextTokenType type
		    InstructionTextTokenType type  , 
			
			// BNHighLevelILTokenEmitter* tokens
		    IntPtr tokens  
		);
	}
}
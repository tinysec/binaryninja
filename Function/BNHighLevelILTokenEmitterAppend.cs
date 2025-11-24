using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNHighLevelILTokenEmitterAppend(BNHighLevelILTokenEmitter* emitter, BNInstructionTextToken* token)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNHighLevelILTokenEmitterAppend"
        )]
		internal static extern void BNHighLevelILTokenEmitterAppend(
			
			// BNHighLevelILTokenEmitter* emitter
		    IntPtr emitter  , 
			
			// BNInstructionTextToken* token
		    in BNInstructionTextToken token  
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDisassemblyTextLine* BNHighLevelILTokenEmitterGetLines(BNHighLevelILTokenEmitter* emitter, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNHighLevelILTokenEmitterGetLines"
        )]
		internal static extern IntPtr BNHighLevelILTokenEmitterGetLines(
			
			// BNHighLevelILTokenEmitter* emitter
		    IntPtr emitter  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}
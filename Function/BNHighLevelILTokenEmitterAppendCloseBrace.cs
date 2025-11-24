using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNHighLevelILTokenEmitterAppendCloseBrace(BNHighLevelILTokenEmitter* emitter)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNHighLevelILTokenEmitterAppendCloseBrace"
        )]
		internal static extern void BNHighLevelILTokenEmitterAppendCloseBrace(
			
			// BNHighLevelILTokenEmitter* emitter
		    IntPtr emitter  
		);
	}
}
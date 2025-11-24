using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNHighLevelILTokenEmitterBeginForceZeroConfidence(BNHighLevelILTokenEmitter* emitter)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNHighLevelILTokenEmitterBeginForceZeroConfidence"
        )]
		internal static extern void BNHighLevelILTokenEmitterBeginForceZeroConfidence(
			
			// BNHighLevelILTokenEmitter* emitter
		    IntPtr emitter  
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNHighLevelILTokenEmitterScopeSeparator(BNHighLevelILTokenEmitter* emitter)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNHighLevelILTokenEmitterScopeSeparator"
        )]
		internal static extern void BNHighLevelILTokenEmitterScopeSeparator(
			
			// BNHighLevelILTokenEmitter* emitter
		    IntPtr emitter  
		);
	}
}
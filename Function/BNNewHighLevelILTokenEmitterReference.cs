using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNHighLevelILTokenEmitter* BNNewHighLevelILTokenEmitterReference(BNHighLevelILTokenEmitter* emitter)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewHighLevelILTokenEmitterReference"
        )]
		internal static extern IntPtr BNNewHighLevelILTokenEmitterReference(
			
			// BNHighLevelILTokenEmitter* emitter
		    IntPtr emitter  
			
		);
	}
}
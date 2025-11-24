using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNBraceRequirement BNHighLevelILTokenEmitterGetBraceRequirement(BNHighLevelILTokenEmitter* emitter)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNHighLevelILTokenEmitterGetBraceRequirement"
        )]
		internal static extern BraceRequirement BNHighLevelILTokenEmitterGetBraceRequirement(
			
			// BNHighLevelILTokenEmitter* emitter
		    IntPtr emitter  
		);
	}
}
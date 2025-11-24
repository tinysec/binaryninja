using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNHighLevelILTokenEmitterSetBraceRequirement(BNHighLevelILTokenEmitter* emitter, BNBraceRequirement required)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNHighLevelILTokenEmitterSetBraceRequirement"
        )]
		internal static extern void BNHighLevelILTokenEmitterSetBraceRequirement(
			
			// BNHighLevelILTokenEmitter* emitter
		    IntPtr emitter  , 
			
			// BNBraceRequirement _required
		    BraceRequirement _required  
			
		);
	}
}
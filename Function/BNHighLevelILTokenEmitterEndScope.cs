using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNHighLevelILTokenEmitterEndScope(BNHighLevelILTokenEmitter* emitter, BNScopeType type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNHighLevelILTokenEmitterEndScope"
        )]
		internal static extern void BNHighLevelILTokenEmitterEndScope(
			
			// BNHighLevelILTokenEmitter* emitter
		    IntPtr emitter  , 
			
			// BNScopeType type
		    ScopeType type  
		);
	}
}
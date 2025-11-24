using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNHighLevelILTokenPrependCollapseBlankIndicator(BNHighLevelILTokenEmitter* emitter)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNHighLevelILTokenPrependCollapseBlankIndicator"
        )]
		internal static extern void BNHighLevelILTokenPrependCollapseBlankIndicator(
			
			// BNHighLevelILTokenEmitter* emitter
		    IntPtr emitter  
		);
	}
}
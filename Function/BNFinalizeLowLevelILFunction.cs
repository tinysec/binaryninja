using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFinalizeLowLevelILFunction(BNLowLevelILFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFinalizeLowLevelILFunction"
        )]
		internal static extern void BNFinalizeLowLevelILFunction(
			
			// BNLowLevelILFunction* func
		    IntPtr func  
		);
	}
}
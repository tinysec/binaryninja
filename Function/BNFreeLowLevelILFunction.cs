using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeLowLevelILFunction(BNLowLevelILFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeLowLevelILFunction"
        )]
		internal static extern void BNFreeLowLevelILFunction(
			
			// BNLowLevelILFunction* func
		    IntPtr func  
			
		);
	}
}
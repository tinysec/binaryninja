using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNGenerateLowLevelILSSAForm(BNLowLevelILFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGenerateLowLevelILSSAForm"
        )]
		internal static extern void BNGenerateLowLevelILSSAForm(
			
			// BNLowLevelILFunction* func
		    IntPtr func  
		);
	}
}
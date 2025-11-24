using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLowLevelILFunction* BNGetLowLevelILNonSSAForm(BNLowLevelILFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetLowLevelILNonSSAForm"
        )]
		internal static extern IntPtr BNGetLowLevelILNonSSAForm(
			
			// BNLowLevelILFunction* func
		    IntPtr func  
			
		);
	}
}
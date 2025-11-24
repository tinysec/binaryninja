using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLowLevelILFunction* BNGetFunctionLowLevelILIfAvailable(BNFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetFunctionLowLevelILIfAvailable"
        )]
		internal static extern IntPtr BNGetFunctionLowLevelILIfAvailable(
			
			// BNFunction* func
		    IntPtr func  
		);
	}
}
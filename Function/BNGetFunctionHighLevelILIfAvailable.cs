using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNHighLevelILFunction* BNGetFunctionHighLevelILIfAvailable(BNFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetFunctionHighLevelILIfAvailable"
        )]
		internal static extern IntPtr BNGetFunctionHighLevelILIfAvailable(
			
			// BNFunction* func
		    IntPtr func  
		);
	}
}
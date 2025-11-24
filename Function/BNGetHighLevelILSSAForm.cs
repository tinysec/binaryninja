using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNHighLevelILFunction* BNGetHighLevelILSSAForm(BNHighLevelILFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetHighLevelILSSAForm"
        )]
		internal static extern IntPtr BNGetHighLevelILSSAForm(
			
			// BNHighLevelILFunction* func
		    IntPtr func  
		);
	}
}
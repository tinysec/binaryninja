using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNFunction* BNGetHighLevelILOwnerFunction(BNHighLevelILFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetHighLevelILOwnerFunction"
        )]
		internal static extern IntPtr BNGetHighLevelILOwnerFunction(
			
			// BNHighLevelILFunction* func
		    IntPtr func  
		);
	}
}
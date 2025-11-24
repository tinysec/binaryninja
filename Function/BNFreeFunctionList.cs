using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeFunctionList(BNFunction** funcs, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeFunctionList"
        )]
		internal static extern void BNFreeFunctionList(
			
			// BNFunction** funcs
		    IntPtr funcs  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}
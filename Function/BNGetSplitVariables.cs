using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNVariable* BNGetSplitVariables(BNFunction* func, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetSplitVariables"
        )]
		internal static extern IntPtr BNGetSplitVariables(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}
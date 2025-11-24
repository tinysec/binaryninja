using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetEarlyReturn(BNFunction* func, uint64_t addr, BNEarlyReturn mode)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetEarlyReturn"
        )]
		internal static extern void BNSetEarlyReturn(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// uint64_t addr
		    ulong addr  , 
			
			// BNEarlyReturn mode
		    EarlyReturn mode  
			
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNUnmergeVariables(BNFunction* func, BNVariable* target, BNVariable* sources, uint64_t sourceCount)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNUnmergeVariables"
        )]
		internal static extern void BNUnmergeVariables(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNVariable* target
		    IntPtr target  , 
			
			// BNVariable* sources
		    IntPtr sources  , 
			
			// uint64_t sourceCount
		    ulong sourceCount  
			
		);
	}
}
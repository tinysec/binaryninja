using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNArchitectureAndAddress* BNGetUnresolvedIndirectBranches(BNFunction* func, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetUnresolvedIndirectBranches"
        )]
		internal static extern IntPtr BNGetUnresolvedIndirectBranches(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
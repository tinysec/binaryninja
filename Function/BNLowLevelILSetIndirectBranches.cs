using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNLowLevelILSetIndirectBranches(BNLowLevelILFunction* func, BNArchitectureAndAddress* branches, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNLowLevelILSetIndirectBranches"
        )]
		internal static extern void BNLowLevelILSetIndirectBranches(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// BNArchitectureAndAddress* branches
			BNArchitectureAndAddress[] branches  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}
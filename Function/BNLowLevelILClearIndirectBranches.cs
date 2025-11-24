using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNLowLevelILClearIndirectBranches(BNLowLevelILFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNLowLevelILClearIndirectBranches"
        )]
		internal static extern void BNLowLevelILClearIndirectBranches(
			
			// BNLowLevelILFunction* func
		    IntPtr func  
		);
	}
}
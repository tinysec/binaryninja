using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLowLevelILFunction* BNGetBasicBlockLowLevelILFunction(BNBasicBlock* block)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetBasicBlockLowLevelILFunction"
        )]
		internal static extern IntPtr BNGetBasicBlockLowLevelILFunction(
			
			// BNBasicBlock* block
		    IntPtr block  
		);
	}
}
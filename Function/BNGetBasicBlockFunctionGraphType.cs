using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNFunctionGraphType BNGetBasicBlockFunctionGraphType(BNBasicBlock* block)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetBasicBlockFunctionGraphType"
        )]
		internal static extern FunctionGraphType BNGetBasicBlockFunctionGraphType(
			
			// BNBasicBlock* block
		    IntPtr block  
		);
	}
}
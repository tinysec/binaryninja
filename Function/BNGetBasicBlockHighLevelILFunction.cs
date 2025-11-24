using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNHighLevelILFunction* BNGetBasicBlockHighLevelILFunction(BNBasicBlock* block)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetBasicBlockHighLevelILFunction"
        )]
		internal static extern IntPtr BNGetBasicBlockHighLevelILFunction(
			
			// BNBasicBlock* block
		    IntPtr block  
			
		);
	}
}
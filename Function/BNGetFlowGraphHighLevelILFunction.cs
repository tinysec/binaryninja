using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNHighLevelILFunction* BNGetFlowGraphHighLevelILFunction(BNFlowGraph* graph)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetFlowGraphHighLevelILFunction"
        )]
		internal static extern IntPtr BNGetFlowGraphHighLevelILFunction(
			
			// BNFlowGraph* graph
		    IntPtr graph  
		);
	}
}
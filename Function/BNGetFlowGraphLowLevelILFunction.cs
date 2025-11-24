using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLowLevelILFunction* BNGetFlowGraphLowLevelILFunction(BNFlowGraph* graph)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetFlowGraphLowLevelILFunction"
        )]
		internal static extern IntPtr BNGetFlowGraphLowLevelILFunction(
			
			// BNFlowGraph* graph
		    IntPtr graph  
		);
	}
}
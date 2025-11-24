using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNFlowGraphNode* BNGetFlowGraphNode(BNFlowGraph* graph, uint64_t i)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetFlowGraphNode"
        )]
		internal static extern IntPtr BNGetFlowGraphNode(
			
			// BNFlowGraph* graph
		    IntPtr graph  , 
			
			// uint64_t i
		    ulong i  
		);
	}
}
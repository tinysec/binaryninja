using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNReplaceFlowGraphNode(BNFlowGraph* graph, uint64_t i, BNFlowGraphNode* newNode)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNReplaceFlowGraphNode"
        )]
		internal static extern void BNReplaceFlowGraphNode(
			
			// BNFlowGraph* graph
		    IntPtr graph  , 
			
			// uint64_t i
		    ulong i  , 
			
			// BNFlowGraphNode* newNode
		    IntPtr newNode  
		);
	}
}
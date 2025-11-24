using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNAddFlowGraphNode(BNFlowGraph* graph, BNFlowGraphNode* node)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAddFlowGraphNode"
        )]
		internal static extern ulong BNAddFlowGraphNode(
			
			// BNFlowGraph* graph
		    IntPtr graph  , 
			
			// BNFlowGraphNode* node
		    IntPtr node  
		);
	}
}
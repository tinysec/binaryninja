using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNFlowGraphEdge* BNGetFlowGraphNodeIncomingEdges(BNFlowGraphNode* node, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetFlowGraphNodeIncomingEdges"
        )]
		internal static extern IntPtr BNGetFlowGraphNodeIncomingEdges(
			
			// BNFlowGraphNode* node
		    IntPtr node  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
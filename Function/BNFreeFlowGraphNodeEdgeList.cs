using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeFlowGraphNodeEdgeList(BNFlowGraphEdge* edges, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeFlowGraphNodeEdgeList"
        )]
		internal static extern void BNFreeFlowGraphNodeEdgeList(
			
			// BNFlowGraphEdge* edges
		    IntPtr edges  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}
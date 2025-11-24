using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFlowGraphNodeSetOutgoingEdgePoints(BNFlowGraphNode* node, uint64_t edgeNum, BNPoint* points, uint64_t pointCount)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFlowGraphNodeSetOutgoingEdgePoints"
        )]
		internal static extern void BNFlowGraphNodeSetOutgoingEdgePoints(
			
			// BNFlowGraphNode* node
		    IntPtr node  , 
			
			// uint64_t edgeNum
		    ulong edgeNum  , 
			
			// BNPoint* points
			BNPoint[] points  , 
			
			// uint64_t pointCount
		    ulong pointCount  
		);
	}
}
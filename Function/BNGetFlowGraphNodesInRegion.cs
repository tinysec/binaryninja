using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNFlowGraphNode** BNGetFlowGraphNodesInRegion(BNFlowGraph* graph, int32_t left, int32_t top, int32_t right, int32_t bottom, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetFlowGraphNodesInRegion"
        )]
		internal static extern IntPtr BNGetFlowGraphNodesInRegion(
			
			// BNFlowGraph* graph
		    IntPtr graph  , 
			
			// int32_t left
		    int left  , 
			
			// int32_t top
		    int top  , 
			
			// int32_t right
		    int right  , 
			
			// int32_t bottom
		    int bottom  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
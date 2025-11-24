using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNFlowGraphNode** BNGetFlowGraphNodes(BNFlowGraph* graph, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetFlowGraphNodes"
        )]
		internal static extern IntPtr BNGetFlowGraphNodes(
			
			// BNFlowGraph* graph
		    IntPtr graph  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
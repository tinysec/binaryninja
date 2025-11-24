using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRenderLayer** BNGetFlowGraphRenderLayers(BNFlowGraph* graph, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetFlowGraphRenderLayers"
        )]
		internal static extern IntPtr BNGetFlowGraphRenderLayers(
			
			// BNFlowGraph* graph
		    IntPtr graph  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
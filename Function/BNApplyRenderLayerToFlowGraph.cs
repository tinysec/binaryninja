using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNApplyRenderLayerToFlowGraph(BNRenderLayer* renderLayer, BNFlowGraph* graph)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNApplyRenderLayerToFlowGraph"
        )]
		internal static extern void BNApplyRenderLayerToFlowGraph(
			
			// BNRenderLayer* renderLayer
		    IntPtr renderLayer  , 
			
			// BNFlowGraph* graph
		    IntPtr graph  
		);
	}
}
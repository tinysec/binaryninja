using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNAddFlowGraphRenderLayer(BNFlowGraph* graph, BNRenderLayer* layer)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAddFlowGraphRenderLayer"
        )]
		internal static extern void BNAddFlowGraphRenderLayer(
			
			// BNFlowGraph* graph
		    IntPtr graph  , 
			
			// BNRenderLayer* layer
		    IntPtr layer  
		);
	}
}
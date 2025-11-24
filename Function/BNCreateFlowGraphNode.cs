using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNFlowGraphNode* BNCreateFlowGraphNode(BNFlowGraph* graph)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateFlowGraphNode"
        )]
		internal static extern IntPtr BNCreateFlowGraphNode(
			
			// BNFlowGraph* graph
		    IntPtr graph  
		);
	}
}
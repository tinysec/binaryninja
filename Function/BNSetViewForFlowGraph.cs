using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetViewForFlowGraph(BNFlowGraph* graph, BNBinaryView* view)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetViewForFlowGraph"
        )]
		internal static extern void BNSetViewForFlowGraph(
			
			// BNFlowGraph* graph
		    IntPtr graph  , 
			
			// BNBinaryView* view
		    IntPtr view  
		);
	}
}
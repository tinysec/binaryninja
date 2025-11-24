using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNIsHighLevelILFlowGraph(BNFlowGraph* graph)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNIsHighLevelILFlowGraph"
        )]
		internal static extern bool BNIsHighLevelILFlowGraph(
			
			// BNFlowGraph* graph
		    IntPtr graph  
		);
	}
}
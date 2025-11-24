using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNIsMediumLevelILFlowGraph(BNFlowGraph* graph)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNIsMediumLevelILFlowGraph"
        )]
		internal static extern bool BNIsMediumLevelILFlowGraph(
			
			// BNFlowGraph* graph
		    IntPtr graph  
		);
	}
}
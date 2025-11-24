using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFlowGraphSetHeight(BNFlowGraph* graph, int32_t height)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFlowGraphSetHeight"
        )]
		internal static extern void BNFlowGraphSetHeight(
			
			// BNFlowGraph* graph
		    IntPtr graph  , 
			
			// int32_t height
		    int height  
		);
	}
}
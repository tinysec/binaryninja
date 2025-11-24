using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFlowGraphSetWidth(BNFlowGraph* graph, int32_t width)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFlowGraphSetWidth"
        )]
		internal static extern void BNFlowGraphSetWidth(
			
			// BNFlowGraph* graph
		    IntPtr graph  , 
			
			// int32_t width
		    int width  
		);
	}
}
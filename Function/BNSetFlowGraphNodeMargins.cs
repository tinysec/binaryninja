using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetFlowGraphNodeMargins(BNFlowGraph* graph, int32_t horiz, int32_t vert)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetFlowGraphNodeMargins"
        )]
		internal static extern void BNSetFlowGraphNodeMargins(
			
			// BNFlowGraph* graph
		    IntPtr graph  , 
			
			// int32_t horiz
		    int horiz  , 
			
			// int32_t vert
		    int vert  
		);
	}
}
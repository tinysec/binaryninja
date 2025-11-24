using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// int32_t BNGetVerticalFlowGraphNodeMargin(BNFlowGraph* graph)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetVerticalFlowGraphNodeMargin"
        )]
		internal static extern int BNGetVerticalFlowGraphNodeMargin(
			
			// BNFlowGraph* graph
		    IntPtr graph  
		);
	}
}
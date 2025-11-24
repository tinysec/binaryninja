using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// int32_t BNGetHorizontalFlowGraphNodeMargin(BNFlowGraph* graph)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetHorizontalFlowGraphNodeMargin"
        )]
		internal static extern int BNGetHorizontalFlowGraphNodeMargin(
			
			// BNFlowGraph* graph
		    IntPtr graph  
			
		);
	}
}
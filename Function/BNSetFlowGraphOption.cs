using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetFlowGraphOption(BNFlowGraph* graph, BNFlowGraphOption option, bool value)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetFlowGraphOption"
        )]
		internal static extern void BNSetFlowGraphOption(
			
			// BNFlowGraph* graph
		    IntPtr graph  , 
			
			// BNFlowGraphOption option
		    FlowGraphOption option  , 
			
			// bool value
		    bool value  
		);
	}
}
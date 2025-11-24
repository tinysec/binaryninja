using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetFunctionForFlowGraph(BNFlowGraph* graph, BNFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetFunctionForFlowGraph"
        )]
		internal static extern void BNSetFunctionForFlowGraph(
			
			// BNFlowGraph* graph
		    IntPtr graph  , 
			
			// BNFunction* func
		    IntPtr func  
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetFlowGraphHighLevelILFunction(BNFlowGraph* graph, BNHighLevelILFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetFlowGraphHighLevelILFunction"
        )]
		internal static extern void BNSetFlowGraphHighLevelILFunction(
			
			// BNFlowGraph* graph
		    IntPtr graph  , 
			
			// BNHighLevelILFunction* func
		    IntPtr func  
		);
	}
}
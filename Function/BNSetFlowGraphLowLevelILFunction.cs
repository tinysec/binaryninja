using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetFlowGraphLowLevelILFunction(BNFlowGraph* graph, BNLowLevelILFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetFlowGraphLowLevelILFunction"
        )]
		internal static extern void BNSetFlowGraphLowLevelILFunction(
			
			// BNFlowGraph* graph
		    IntPtr graph  , 
			
			// BNLowLevelILFunction* func
		    IntPtr func  
		);
	}
}
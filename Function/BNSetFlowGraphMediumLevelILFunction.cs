using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetFlowGraphMediumLevelILFunction(BNFlowGraph* graph, BNMediumLevelILFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetFlowGraphMediumLevelILFunction"
        )]
		internal static extern void BNSetFlowGraphMediumLevelILFunction(
			
			// BNFlowGraph* graph
		    IntPtr graph  , 
			
			// BNMediumLevelILFunction* func
		    IntPtr func  
		);
	}
}
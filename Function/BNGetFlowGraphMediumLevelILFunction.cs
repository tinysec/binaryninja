using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNMediumLevelILFunction* BNGetFlowGraphMediumLevelILFunction(BNFlowGraph* graph)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetFlowGraphMediumLevelILFunction"
        )]
		internal static extern IntPtr BNGetFlowGraphMediumLevelILFunction(
			
			// BNFlowGraph* graph
		    IntPtr graph  
		);
	}
}
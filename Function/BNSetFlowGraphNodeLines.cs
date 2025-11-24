using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetFlowGraphNodeLines(BNFlowGraphNode* node, BNDisassemblyTextLine* lines, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetFlowGraphNodeLines"
        )]
		internal static extern void BNSetFlowGraphNodeLines(
			
			// BNFlowGraphNode* node
		    IntPtr node  , 
			
			// BNDisassemblyTextLine* lines
			BNDisassemblyTextLine[] lines  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}
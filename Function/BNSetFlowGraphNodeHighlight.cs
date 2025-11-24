using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetFlowGraphNodeHighlight(BNFlowGraphNode* node, BNHighlightColor color)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetFlowGraphNodeHighlight"
        )]
		internal static extern void BNSetFlowGraphNodeHighlight(
			
			// BNFlowGraphNode* node
		    IntPtr node  , 
			
			// BNHighlightColor color
		    HighlightColor color  
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNHighlightColor BNGetFlowGraphNodeHighlight(BNFlowGraphNode* node)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetFlowGraphNodeHighlight"
        )]
		internal static extern BNHighlightColor BNGetFlowGraphNodeHighlight(
			
			// BNFlowGraphNode* node
		    IntPtr node  
		);
	}
}
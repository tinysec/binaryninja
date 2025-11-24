using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNFlowGraph* BNGetFlowGraphNodeOwner(BNFlowGraphNode* node)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetFlowGraphNodeOwner"
        )]
		internal static extern IntPtr BNGetFlowGraphNodeOwner(
			
			// BNFlowGraphNode* node
		    IntPtr node  
			
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeFlowGraphNode(BNFlowGraphNode* node)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeFlowGraphNode"
        )]
		internal static extern void BNFreeFlowGraphNode(
			
			// BNFlowGraphNode* node
		    IntPtr node  
			
		);
	}
}
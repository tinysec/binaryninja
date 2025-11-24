using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFlowGraphNodeSetX(BNFlowGraphNode* node, int32_t x)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFlowGraphNodeSetX"
        )]
		internal static extern void BNFlowGraphNodeSetX(
			
			// BNFlowGraphNode* node
		    IntPtr node  , 
			
			// int32_t x
		    int x  
		);
	}
}
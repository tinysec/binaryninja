using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFlowGraphNodeSetY(BNFlowGraphNode* node, int32_t y)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFlowGraphNodeSetY"
        )]
		internal static extern void BNFlowGraphNodeSetY(
			
			// BNFlowGraphNode* node
		    IntPtr node  , 
			
			// int32_t y
		    int y  
		);
	}
}
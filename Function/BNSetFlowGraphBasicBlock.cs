using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetFlowGraphBasicBlock(BNFlowGraphNode* node, BNBasicBlock* block)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetFlowGraphBasicBlock"
        )]
		internal static extern void BNSetFlowGraphBasicBlock(
			
			// BNFlowGraphNode* node
		    IntPtr node  , 
			
			// BNBasicBlock* block
		    IntPtr block  
		);
	}
}
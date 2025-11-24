using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNBasicBlock* BNGetFlowGraphBasicBlock(BNFlowGraphNode* node)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetFlowGraphBasicBlock"
        )]
		internal static extern IntPtr BNGetFlowGraphBasicBlock(
			
			// BNFlowGraphNode* node
		    IntPtr node  
		);
	}
}
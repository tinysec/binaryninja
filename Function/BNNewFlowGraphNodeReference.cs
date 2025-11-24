using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNFlowGraphNode* BNNewFlowGraphNodeReference(BNFlowGraphNode* node)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewFlowGraphNodeReference"
        )]
		internal static extern IntPtr BNNewFlowGraphNodeReference(
			
			// BNFlowGraphNode* node
		    IntPtr node  
			
		);
	}
}
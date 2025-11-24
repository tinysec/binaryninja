using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNPendingBasicBlockEdge* BNGetBasicBlockPendingOutgoingEdges(BNBasicBlock* block, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetBasicBlockPendingOutgoingEdges"
        )]
		internal static extern IntPtr BNGetBasicBlockPendingOutgoingEdges(
			
			// BNBasicBlock* block
		    IntPtr block  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
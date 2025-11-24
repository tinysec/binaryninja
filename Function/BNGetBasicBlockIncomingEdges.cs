using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNBasicBlockEdge* BNGetBasicBlockIncomingEdges(BNBasicBlock* block, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetBasicBlockIncomingEdges"
        )]
		internal static extern IntPtr BNGetBasicBlockIncomingEdges(
			
			// BNBasicBlock* block
		    IntPtr block  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
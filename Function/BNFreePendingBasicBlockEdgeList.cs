using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreePendingBasicBlockEdgeList(BNPendingBasicBlockEdge* edges)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreePendingBasicBlockEdgeList"
        )]
		internal static extern void BNFreePendingBasicBlockEdgeList(
			
			// BNPendingBasicBlockEdge* edges
		    IntPtr edges  
		);
	}
}
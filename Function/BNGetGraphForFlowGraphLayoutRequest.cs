using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNFlowGraph* BNGetGraphForFlowGraphLayoutRequest(BNFlowGraphLayoutRequest* layout)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetGraphForFlowGraphLayoutRequest"
        )]
		internal static extern IntPtr BNGetGraphForFlowGraphLayoutRequest(
			
			// BNFlowGraphLayoutRequest* layout
		    IntPtr layout  
		);
	}
}
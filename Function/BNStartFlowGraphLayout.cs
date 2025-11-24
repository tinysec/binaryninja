using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNFlowGraphLayoutRequest* BNStartFlowGraphLayout(BNFlowGraph* graph, void* ctxt, void** func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNStartFlowGraphLayout"
        )]
		internal static extern IntPtr BNStartFlowGraphLayout(
			
			// BNFlowGraph* graph
		    IntPtr graph  , 
			
			// void* ctxt
		    IntPtr ctxt  , 
			
			// void** func
		    IntPtr func  
			
		);
	}
}
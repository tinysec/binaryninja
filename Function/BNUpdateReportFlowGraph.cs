using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNUpdateReportFlowGraph(BNReportCollection* reports, uint64_t i, BNFlowGraph* graph)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNUpdateReportFlowGraph"
        )]
		internal static extern void BNUpdateReportFlowGraph(
			
			// BNReportCollection* reports
		    IntPtr reports  , 
			
			// uint64_t i
		    ulong i  , 
			
			// BNFlowGraph* graph
		    IntPtr graph  
			
		);
	}
}
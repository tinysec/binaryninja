using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeWorkflowList(BNWorkflow** workflows, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeWorkflowList"
        )]
		internal static extern void BNFreeWorkflowList(
			
			// BNWorkflow** workflows
		    IntPtr workflows  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}
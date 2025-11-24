using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNWorkflowSize(BNWorkflow* workflow)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNWorkflowSize"
        )]
		internal static extern ulong BNWorkflowSize(
			
			// BNWorkflow* workflow
		    IntPtr workflow  
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNGetWorkflowName(BNWorkflow* workflow)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetWorkflowName"
        )]
		internal static extern IntPtr BNGetWorkflowName(
			
			// BNWorkflow* workflow
		    IntPtr workflow  
			
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNWorkflow* BNNewWorkflowReference(BNWorkflow* workflow)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewWorkflowReference"
        )]
		internal static extern IntPtr BNNewWorkflowReference(
			
			// BNWorkflow* workflow
		    IntPtr workflow  
			
		);
	}
}
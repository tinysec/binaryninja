using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNWorkflow* BNGetWorkflowForBinaryView(BNBinaryView* view)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetWorkflowForBinaryView"
        )]
		internal static extern IntPtr BNGetWorkflowForBinaryView(
			
			// BNBinaryView* view
		    IntPtr view  
		);
	}
}
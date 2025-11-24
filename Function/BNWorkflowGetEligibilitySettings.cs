using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char** BNWorkflowGetEligibilitySettings(BNWorkflow* workflow, uint64_t* inoutSize)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNWorkflowGetEligibilitySettings"
        )]
		internal static extern IntPtr BNWorkflowGetEligibilitySettings(
			
			// BNWorkflow* workflow
		    IntPtr workflow  , 
			
			// uint64_t* inoutSize
		    IntPtr inoutSize  
			
		);
	}
}
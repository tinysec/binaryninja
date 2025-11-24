using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNActivity* BNWorkflowRegisterActivity(BNWorkflow* workflow, BNActivity* activity, const char** subactivities, uint64_t size)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNWorkflowRegisterActivity"
        )]
		internal static extern IntPtr BNWorkflowRegisterActivity(
			
			// BNWorkflow* workflow
		    IntPtr workflow  , 
			
			// BNActivity* activity
		    IntPtr activity  , 
			
			// const char** subactivities
		    string[] subactivities  , 
			
			// uint64_t size
		    ulong size  
			
		);
	}
}
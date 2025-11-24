using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFinishBackgroundTask(BNBackgroundTask* task)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFinishBackgroundTask"
        )]
		internal static extern void BNFinishBackgroundTask(
			
			// BNBackgroundTask* task
		    IntPtr task  
		);
	}
}
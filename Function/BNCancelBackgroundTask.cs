using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNCancelBackgroundTask(BNBackgroundTask* task)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCancelBackgroundTask"
        )]
		internal static extern void BNCancelBackgroundTask(
			
			// BNBackgroundTask* task
		    IntPtr task  
		);
	}
}
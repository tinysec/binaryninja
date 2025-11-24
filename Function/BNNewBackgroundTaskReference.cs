using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNBackgroundTask* BNNewBackgroundTaskReference(BNBackgroundTask* task)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNNewBackgroundTaskReference"
        )]
		internal static extern IntPtr BNNewBackgroundTaskReference(
			
			// BNBackgroundTask* task
		    IntPtr task  
		);
	}
}
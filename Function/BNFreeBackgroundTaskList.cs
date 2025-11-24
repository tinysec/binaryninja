using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeBackgroundTaskList(BNBackgroundTask** tasks, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeBackgroundTaskList"
        )]
		internal static extern void BNFreeBackgroundTaskList(
			
			// BNBackgroundTask** tasks
		    IntPtr tasks  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}
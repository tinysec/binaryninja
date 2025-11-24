using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNBackgroundTask** BNGetRunningBackgroundTasks(uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetRunningBackgroundTasks"
        )]
		internal static extern IntPtr BNGetRunningBackgroundTasks(
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
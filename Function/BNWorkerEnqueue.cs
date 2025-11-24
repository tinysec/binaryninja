using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNWorkerEnqueue(void* ctxt, void** action)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNWorkerEnqueue"
        )]
		internal static extern void BNWorkerEnqueue(
			
			// void* ctxt
		    IntPtr ctxt  , 
			
			// void** action
		    IntPtr action  
			
		);
	}
}
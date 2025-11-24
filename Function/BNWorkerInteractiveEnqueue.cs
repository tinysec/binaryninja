using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNWorkerInteractiveEnqueue(void* ctxt, void** action)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNWorkerInteractiveEnqueue"
        )]
		internal static extern void BNWorkerInteractiveEnqueue(
			
			// void* ctxt
		    IntPtr ctxt  , 
			
			// void** action
		    IntPtr action  
			
		);
	}
}
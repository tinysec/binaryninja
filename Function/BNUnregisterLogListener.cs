using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNUnregisterLogListener(BNLogListener* listener)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNUnregisterLogListener"
        )]
		internal static extern void BNUnregisterLogListener(
			
			// BNLogListener* listener
		    IntPtr listener  
		);
	}
}
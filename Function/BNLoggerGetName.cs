using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// char* BNLoggerGetName(BNLogger* logger)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNLoggerGetName"
        )]
		internal static extern IntPtr BNLoggerGetName(
			
			// BNLogger* logger
		    IntPtr logger  
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNLogToStderr(BNLogLevel minimumLevel)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNLogToStderr"
        )]
		public static extern void BNLogToStderr(
			
			// BNLogLevel minimumLevel
		    LogLevel minimumLevel  
		);
	}
}
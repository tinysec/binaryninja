using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNLogToStdout(BNLogLevel minimumLevel)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNLogToStdout"
        )]
		public static extern void BNLogToStdout(
			
			// BNLogLevel minimumLevel
		    LogLevel minimumLevel  
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNLoggerGetSessionId(BNLogger* logger)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNLoggerGetSessionId"
        )]
		internal static extern ulong BNLoggerGetSessionId(
			
			// BNLogger* logger
		    IntPtr logger  
		);
	}
}
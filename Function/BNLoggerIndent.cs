using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNLoggerIndent(BNLogger* logger)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNLoggerIndent"
        )]
		internal static extern void BNLoggerIndent(
			
			// BNLogger* logger
		    IntPtr logger  
		);
	}
}
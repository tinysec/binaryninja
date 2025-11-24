using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLogger* BNNewLoggerReference(BNLogger* logger)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewLoggerReference"
        )]
		internal static extern IntPtr BNNewLoggerReference(
			
			// BNLogger* logger
		    IntPtr logger  
			
		);
	}
}
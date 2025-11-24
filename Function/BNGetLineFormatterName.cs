using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNGetLineFormatterName(BNLineFormatter* formatter)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetLineFormatterName"
        )]
		internal static extern IntPtr BNGetLineFormatterName(
			
			// BNLineFormatter* formatter
		    IntPtr formatter  
			
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetDisassemblyGutterWidth(BNDisassemblySettings* settings, uint64_t width)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetDisassemblyGutterWidth"
        )]
		internal static extern void BNSetDisassemblyGutterWidth(
			
			// BNDisassemblySettings* settings
		    IntPtr settings  , 
			
			// uint64_t width
		    ulong width  
			
		);
	}
}
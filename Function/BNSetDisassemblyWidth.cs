using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetDisassemblyWidth(BNDisassemblySettings* settings, uint64_t width)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetDisassemblyWidth"
        )]
		internal static extern void BNSetDisassemblyWidth(
			
			// BNDisassemblySettings* settings
		    IntPtr settings  , 
			
			// uint64_t width
		    ulong width  
		);
	}
}
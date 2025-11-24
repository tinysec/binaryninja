using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetDisassemblyAddressMode(BNDisassemblySettings* settings, BNDisassemblyAddressMode mode)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetDisassemblyAddressMode"
        )]
		internal static extern void BNSetDisassemblyAddressMode(
			
			// BNDisassemblySettings* settings
		    IntPtr settings  , 
			
			// BNDisassemblyAddressMode mode
		    DisassemblyAddressMode mode  
			
		);
	}
}
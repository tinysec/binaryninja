using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDisassemblyAddressMode BNGetDisassemblyAddressMode(BNDisassemblySettings* settings)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetDisassemblyAddressMode"
        )]
		internal static extern DisassemblyAddressMode BNGetDisassemblyAddressMode(
			
			// BNDisassemblySettings* settings
		    IntPtr settings  
			
		);
	}
}
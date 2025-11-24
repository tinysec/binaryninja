using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDisassemblySettings* BNDuplicateDisassemblySettings(BNDisassemblySettings* settings)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNDuplicateDisassemblySettings"
        )]
		internal static extern IntPtr BNDuplicateDisassemblySettings(
			
			// BNDisassemblySettings* settings
		    IntPtr settings  
			
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetDisassemblyMaximumSymbolWidth(BNDisassemblySettings* settings)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetDisassemblyMaximumSymbolWidth"
        )]
		internal static extern ulong BNGetDisassemblyMaximumSymbolWidth(
			
			// BNDisassemblySettings* settings
		    IntPtr settings  
			
		);
	}
}
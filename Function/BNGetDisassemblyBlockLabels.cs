using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDisassemblyBlockLabels BNGetDisassemblyBlockLabels(BNDisassemblySettings* settings)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetDisassemblyBlockLabels"
        )]
		internal static extern DisassemblyBlockLabels BNGetDisassemblyBlockLabels(
			
			// BNDisassemblySettings* settings
		    IntPtr settings  
			
		);
	}
}
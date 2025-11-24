using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDisassemblyCallParameterHints BNGetDisassemblyCallParameterHints(BNDisassemblySettings* settings)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetDisassemblyCallParameterHints"
        )]
		internal static extern DisassemblyCallParameterHints BNGetDisassemblyCallParameterHints(
			
			// BNDisassemblySettings* settings
		    IntPtr settings  
			
		);
	}
}
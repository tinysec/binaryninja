using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetDisassemblyCallParameterHints(BNDisassemblySettings* settings, BNDisassemblyCallParameterHints hints)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetDisassemblyCallParameterHints"
        )]
		internal static extern void BNSetDisassemblyCallParameterHints(
			
			// BNDisassemblySettings* settings
		    IntPtr settings  , 
			
			// BNDisassemblyCallParameterHints hints
		    DisassemblyCallParameterHints hints  
			
		);
	}
}
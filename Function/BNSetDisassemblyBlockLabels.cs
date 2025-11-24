using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetDisassemblyBlockLabels(BNDisassemblySettings* settings, BNDisassemblyBlockLabels labels)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetDisassemblyBlockLabels"
        )]
		internal static extern void BNSetDisassemblyBlockLabels(
			
			// BNDisassemblySettings* settings
		    IntPtr settings  , 
			
			// BNDisassemblyBlockLabels labels
		    DisassemblyBlockLabels labels  
			
		);
	}
}
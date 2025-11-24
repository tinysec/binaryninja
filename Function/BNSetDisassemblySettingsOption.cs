using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetDisassemblySettingsOption(BNDisassemblySettings* settings, BNDisassemblyOption option, bool state)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetDisassemblySettingsOption"
        )]
		internal static extern void BNSetDisassemblySettingsOption(
			
			// BNDisassemblySettings* settings
		    IntPtr settings  , 
			
			// BNDisassemblyOption option
		    DisassemblyOption option  , 
			
			// bool state
		    bool state  
			
		);
	}
}
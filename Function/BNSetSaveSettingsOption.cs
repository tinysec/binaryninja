using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetSaveSettingsOption(BNSaveSettings* settings, BNSaveOption option, bool state)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetSaveSettingsOption"
        )]
		internal static extern void BNSetSaveSettingsOption(
			
			// BNSaveSettings* settings
		    IntPtr settings  , 
			
			// BNSaveOption option
		    SaveOption option  , 
			
			// bool state
		    bool state  
		);
	}
}
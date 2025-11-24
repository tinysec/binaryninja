using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNSaveSettings* BNNewSaveSettingsReference(BNSaveSettings* settings)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewSaveSettingsReference"
        )]
		internal static extern IntPtr BNNewSaveSettingsReference(
			
			// BNSaveSettings* settings
		    IntPtr settings  
			
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// char* BNSerializeSettings(BNSettings* settings, BNBinaryView* view, BNFunction* func, BNSettingsScope scope)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSerializeSettings"
        )]
		internal static extern IntPtr BNSerializeSettings(
			
			// BNSettings* settings
		    IntPtr settings  , 
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNSettingsScope scope
		    SettingsScope scope  
		);
	}
}
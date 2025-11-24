using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNSettingsRegisterSetting(BNSettings* settings, const char* key, const char* properties)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSettingsRegisterSetting"
        )]
		internal static extern bool BNSettingsRegisterSetting(
			
			// BNSettings* settings
		    IntPtr settings  , 
			
			// const char* key
		    string key  , 
			
			// const char* properties
		    string properties  
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// char** BNSettingsQueryPropertyStringList(BNSettings* settings, const char* key, const char* property, uint64_t* inoutSize)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSettingsQueryPropertyStringList"
        )]
		internal static extern IntPtr BNSettingsQueryPropertyStringList(
			
			// BNSettings* settings
		    IntPtr settings  , 
			
			// const char* key
		    string key  , 
			
			// const char* property
		    string property  , 
			
			// uint64_t* inoutSize
		    out ulong inoutSize  
		);
	}
}
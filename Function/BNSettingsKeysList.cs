using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// char** BNSettingsKeysList(BNSettings* settings, uint64_t* inoutSize)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSettingsKeysList"
        )]
		internal static extern IntPtr BNSettingsKeysList(
			
			// BNSettings* settings
		    IntPtr settings  , 
			
			// uint64_t* inoutSize
			out ulong inoutSize  
		);
	}
}
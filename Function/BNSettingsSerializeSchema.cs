using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// char* BNSettingsSerializeSchema(BNSettings* settings)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSettingsSerializeSchema"
        )]
		internal static extern IntPtr BNSettingsSerializeSchema(
			
			// BNSettings* settings
		    IntPtr settings  
		);
	}
}
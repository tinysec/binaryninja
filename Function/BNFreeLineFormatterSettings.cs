using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeLineFormatterSettings(BNLineFormatterSettings* settings)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeLineFormatterSettings"
        )]
		internal static extern void BNFreeLineFormatterSettings(
			
			// BNLineFormatterSettings* settings
		    IntPtr settings  
			
		);
	}
}
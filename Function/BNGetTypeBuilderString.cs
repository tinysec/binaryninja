using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNGetTypeBuilderString(BNTypeBuilder* type, BNPlatform* platform)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetTypeBuilderString"
        )]
		internal static extern IntPtr BNGetTypeBuilderString(
			
			// BNTypeBuilder* type
		    IntPtr type  , 
			
			// BNPlatform* platform
		    IntPtr platform  
			
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNGetTypeBuilderStringAfterName(BNTypeBuilder* type, BNPlatform* platform)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetTypeBuilderStringAfterName"
        )]
		internal static extern IntPtr BNGetTypeBuilderStringAfterName(
			
			// BNTypeBuilder* type
		    IntPtr type  , 
			
			// BNPlatform* platform
		    IntPtr platform  
			
		);
	}
}
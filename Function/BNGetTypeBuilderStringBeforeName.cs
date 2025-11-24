using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNGetTypeBuilderStringBeforeName(BNTypeBuilder* type, BNPlatform* platform)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetTypeBuilderStringBeforeName"
        )]
		internal static extern IntPtr BNGetTypeBuilderStringBeforeName(
			
			// BNTypeBuilder* type
		    IntPtr type  , 
			
			// BNPlatform* platform
		    IntPtr platform  
			
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// char* BNGetTypeStringBeforeName(BNType* type, BNPlatform* platform, BNTokenEscapingType escaping)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetTypeStringBeforeName"
        )]
		internal static extern IntPtr BNGetTypeStringBeforeName(
			
			// BNType* type
		    IntPtr type  , 
			
			// BNPlatform* platform
		    IntPtr platform  , 
			
			// BNTokenEscapingType escaping
		    TokenEscapingType escaping  
		);
	}
}
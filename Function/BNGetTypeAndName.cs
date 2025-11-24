using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNGetTypeAndName(BNType* type, BNQualifiedName* name, BNTokenEscapingType escaping)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetTypeAndName"
        )]
		internal static extern IntPtr BNGetTypeAndName(
			
			// BNType* type
		    IntPtr type  , 
			
			// BNQualifiedName* name
		    IntPtr name  , 
			
			// BNTokenEscapingType escaping
		    TokenEscapingType escaping  
			
		);
	}
}
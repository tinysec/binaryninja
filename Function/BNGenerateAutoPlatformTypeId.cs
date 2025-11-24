using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNGenerateAutoPlatformTypeId(BNPlatform* platform, BNQualifiedName* name)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGenerateAutoPlatformTypeId"
        )]
		internal static extern IntPtr BNGenerateAutoPlatformTypeId(
			
			// BNPlatform* platform
		    IntPtr platform  , 
			
			// BNQualifiedName* name
		    IntPtr name  
			
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNType* BNGetPlatformTypeByName(BNPlatform* platform, BNQualifiedName* name)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetPlatformTypeByName"
        )]
		internal static extern IntPtr BNGetPlatformTypeByName(
			
			// BNPlatform* platform
		    IntPtr platform  , 
			
			// BNQualifiedName* name
		    in BNQualifiedName name  
		);
	}
}
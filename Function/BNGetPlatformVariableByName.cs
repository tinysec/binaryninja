using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNType* BNGetPlatformVariableByName(BNPlatform* platform, BNQualifiedName* name)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetPlatformVariableByName"
        )]
		internal static extern IntPtr BNGetPlatformVariableByName(
			
			// BNPlatform* platform
		    IntPtr platform  , 
			
			// BNQualifiedName* name
		    in BNQualifiedName name  
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNType* BNGetPlatformFunctionByName(BNPlatform* platform, BNQualifiedName* name, bool exactMatch)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetPlatformFunctionByName"
        )]
		internal static extern IntPtr BNGetPlatformFunctionByName(
			
			// BNPlatform* platform
		    IntPtr platform  , 
			
			// BNQualifiedName* name
		    in BNQualifiedName name  , 
			
			// bool exactMatch
		    bool exactMatch  
		);
	}
}
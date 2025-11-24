using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNPlatform* BNTypeContainerGetPlatform(BNTypeContainer* container)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNTypeContainerGetPlatform"
        )]
		internal static extern IntPtr BNTypeContainerGetPlatform(
			
			// BNTypeContainer* container
		    IntPtr container  
		);
	}
}
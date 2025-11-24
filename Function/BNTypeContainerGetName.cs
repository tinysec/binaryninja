using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNTypeContainerGetName(BNTypeContainer* container)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNTypeContainerGetName"
        )]
		internal static extern IntPtr BNTypeContainerGetName(
			
			// BNTypeContainer* container
		    IntPtr container  
		);
	}
}
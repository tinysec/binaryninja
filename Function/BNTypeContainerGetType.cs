using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTypeContainerType BNTypeContainerGetType(BNTypeContainer* container)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNTypeContainerGetType"
        )]
		internal static extern TypeContainerType BNTypeContainerGetType(
			
			// BNTypeContainer* container
		    IntPtr container  
		);
	}
}
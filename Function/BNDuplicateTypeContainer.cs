using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTypeContainer* BNDuplicateTypeContainer(BNTypeContainer* container)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNDuplicateTypeContainer"
        )]
		internal static extern IntPtr BNDuplicateTypeContainer(
			
			// BNTypeContainer* container
		    IntPtr container  
		);
	}
}
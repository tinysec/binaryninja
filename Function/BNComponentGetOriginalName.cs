using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNComponentGetOriginalName(BNComponent* component)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNComponentGetOriginalName"
        )]
		internal static extern IntPtr BNComponentGetOriginalName(
			
			// BNComponent* component
		    IntPtr component  
		);
	}
}
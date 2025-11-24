using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNFieldResolutionInfo* BNNewFieldResolutionInfoReference(BNFieldResolutionInfo* info)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewFieldResolutionInfoReference"
        )]
		internal static extern IntPtr BNNewFieldResolutionInfoReference(
			
			// BNFieldResolutionInfo* info
		    IntPtr info  
			
		);
	}
}
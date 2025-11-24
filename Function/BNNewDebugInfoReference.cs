using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDebugInfo* BNNewDebugInfoReference(BNDebugInfo* debugInfo)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNNewDebugInfoReference"
        )]
		internal static extern IntPtr BNNewDebugInfoReference(
			
			// BNDebugInfo* debugInfo
		    IntPtr debugInfo  
		);
	}
}
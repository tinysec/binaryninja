using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDebugInfoParser** BNGetDebugInfoParsersForView(BNBinaryView* view, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetDebugInfoParsersForView"
        )]
		internal static extern IntPtr BNGetDebugInfoParsersForView(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}
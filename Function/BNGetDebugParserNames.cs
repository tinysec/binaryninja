using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char** BNGetDebugParserNames(BNDebugInfo* debugInfo, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetDebugParserNames"
        )]
		internal static extern IntPtr BNGetDebugParserNames(
			
			// BNDebugInfo* debugInfo
		    IntPtr debugInfo  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}
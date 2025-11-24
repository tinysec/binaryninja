using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNType* BNGetDebugTypeByName(BNDebugInfo* debugInfo, const char* parserName, const char* typeName)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetDebugTypeByName"
        )]
		internal static extern IntPtr BNGetDebugTypeByName(
			
			// BNDebugInfo* debugInfo
		    IntPtr debugInfo  , 
			
			// const char* parserName
		    string parserName  , 
			
			// const char* typeName
		    string typeName  
			
		);
	}
}
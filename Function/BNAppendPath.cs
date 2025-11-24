using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNAppendPath(const char* path, const char* part)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNAppendPath"
        )]
		internal static extern IntPtr BNAppendPath(
			
			// const char* path
		    string path  , 
			
			// const char* part
		    string part  
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNTransformSessionSelectFiles(BNTransformSession* session, const char** files, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNTransformSessionSelectFiles"
        )]
		internal static extern bool BNTransformSessionSelectFiles(
			
			// BNTransformSession* session
		    IntPtr session  , 
			
			// const char** files
		    string[] files  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}
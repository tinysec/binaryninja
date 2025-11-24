using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNCopyFile(const char* source, const char* dest)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNCopyFile"
        )]
		internal static extern bool BNCopyFile(
			
			// const char* source
		    string source  , 
			
			// const char* dest
		    string dest  
		);
	}
}
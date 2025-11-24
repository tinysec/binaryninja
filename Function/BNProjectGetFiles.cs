using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNProjectFile** BNProjectGetFiles(BNProject* project, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNProjectGetFiles"
        )]
		internal static extern IntPtr BNProjectGetFiles(
			
			// BNProject* project
		    IntPtr project  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}
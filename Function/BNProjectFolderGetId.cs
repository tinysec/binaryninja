using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNProjectFolderGetId(BNProjectFolder* folder)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNProjectFolderGetId"
        )]
		internal static extern IntPtr BNProjectFolderGetId(
			
			// BNProjectFolder* folder
		    IntPtr folder  
			
		);
	}
}
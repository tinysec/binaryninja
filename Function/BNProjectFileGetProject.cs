using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNProject* BNProjectFileGetProject(BNProjectFile* file)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNProjectFileGetProject"
        )]
		internal static extern IntPtr BNProjectFileGetProject(
			
			// BNProjectFile* file
		    IntPtr file  
			
		);
	}
}
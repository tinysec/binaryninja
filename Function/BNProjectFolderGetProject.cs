using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNProject* BNProjectFolderGetProject(BNProjectFolder* folder)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNProjectFolderGetProject"
        )]
		internal static extern IntPtr BNProjectFolderGetProject(
			
			// BNProjectFolder* folder
		    IntPtr folder  
			
		);
	}
}
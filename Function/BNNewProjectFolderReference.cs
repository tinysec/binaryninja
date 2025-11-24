using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNProjectFolder* BNNewProjectFolderReference(BNProjectFolder* folder)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewProjectFolderReference"
        )]
		internal static extern IntPtr BNNewProjectFolderReference(
			
			// BNProjectFolder* folder
		    IntPtr folder  
			
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNProjectFolder* BNProjectFolderGetParent(BNProjectFolder* folder)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNProjectFolderGetParent"
        )]
		internal static extern IntPtr BNProjectFolderGetParent(
			
			// BNProjectFolder* folder
		    IntPtr folder  
			
		);
	}
}
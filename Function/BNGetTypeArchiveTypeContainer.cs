using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTypeContainer* BNGetTypeArchiveTypeContainer(BNTypeArchive* archive)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetTypeArchiveTypeContainer"
        )]
		internal static extern IntPtr BNGetTypeArchiveTypeContainer(
			
			// BNTypeArchive* archive
		    IntPtr archive  
			
		);
	}
}
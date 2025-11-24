using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNProjectFile* BNGetProjectFile(BNFileMetadata* file)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetProjectFile"
        )]
		internal static extern IntPtr BNGetProjectFile(
			
			// BNFileMetadata* file
		    IntPtr file  
		);
	}
}
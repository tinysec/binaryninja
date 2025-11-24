using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// char* BNGetTemporaryFilePath(BNTemporaryFile* file)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetTemporaryFilePath"
        )]
		internal static extern IntPtr BNGetTemporaryFilePath(
			
			// BNTemporaryFile* file
		    IntPtr file  
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDataBuffer* BNGetTemporaryFileContents(BNTemporaryFile* file)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetTemporaryFileContents"
        )]
		internal static extern IntPtr BNGetTemporaryFileContents(
			
			// BNTemporaryFile* file
		    IntPtr file  
		);
	}
}
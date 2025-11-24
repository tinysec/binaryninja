using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTemporaryFile* BNCreateTemporaryFileWithContents(BNDataBuffer* data)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateTemporaryFileWithContents"
        )]
		internal static extern IntPtr BNCreateTemporaryFileWithContents(
			
			// BNDataBuffer* data
		    IntPtr data  
		);
	}
}
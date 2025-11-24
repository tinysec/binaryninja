using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetProjectFile(BNFileMetadata* file, BNProjectFile* pfile)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetProjectFile"
        )]
		internal static extern void BNSetProjectFile(
			
			// BNFileMetadata* file
		    IntPtr file  , 
			
			// BNProjectFile* pfile
		    IntPtr pfile  
		);
	}
}
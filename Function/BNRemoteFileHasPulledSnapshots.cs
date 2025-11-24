using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNRemoteFileHasPulledSnapshots(BNRemoteFile* file)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRemoteFileHasPulledSnapshots"
        )]
		internal static extern bool BNRemoteFileHasPulledSnapshots(
			
			// BNRemoteFile* file
		    IntPtr file  
			
		);
	}
}
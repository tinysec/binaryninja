using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRemote* BNCollaborationGetRemoteForLocalTypeArchive(BNTypeArchive* archive)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationGetRemoteForLocalTypeArchive"
        )]
		internal static extern IntPtr BNCollaborationGetRemoteForLocalTypeArchive(
			
			// BNTypeArchive* archive
		    IntPtr archive  
		);
	}
}
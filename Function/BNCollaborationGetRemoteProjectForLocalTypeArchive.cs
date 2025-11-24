using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRemoteProject* BNCollaborationGetRemoteProjectForLocalTypeArchive(BNTypeArchive* archive)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationGetRemoteProjectForLocalTypeArchive"
        )]
		internal static extern IntPtr BNCollaborationGetRemoteProjectForLocalTypeArchive(
			
			// BNTypeArchive* archive
		    IntPtr archive  
		);
	}
}
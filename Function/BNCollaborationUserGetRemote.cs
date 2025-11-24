using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRemote* BNCollaborationUserGetRemote(BNCollaborationUser* user)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationUserGetRemote"
        )]
		internal static extern IntPtr BNCollaborationUserGetRemote(
			
			// BNCollaborationUser* user
		    IntPtr user  
		);
	}
}
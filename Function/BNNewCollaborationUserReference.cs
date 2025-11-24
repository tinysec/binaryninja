using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNCollaborationUser* BNNewCollaborationUserReference(BNCollaborationUser* user)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewCollaborationUserReference"
        )]
		internal static extern IntPtr BNNewCollaborationUserReference(
			
			// BNCollaborationUser* user
		    IntPtr user  
			
		);
	}
}
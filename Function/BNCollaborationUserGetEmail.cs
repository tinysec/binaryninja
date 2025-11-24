using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNCollaborationUserGetEmail(BNCollaborationUser* user)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationUserGetEmail"
        )]
		internal static extern IntPtr BNCollaborationUserGetEmail(
			
			// BNCollaborationUser* user
		    IntPtr user  
		);
	}
}
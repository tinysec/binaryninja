using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNCollaborationUserGetId(BNCollaborationUser* user)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationUserGetId"
        )]
		internal static extern IntPtr BNCollaborationUserGetId(
			
			// BNCollaborationUser* user
		    IntPtr user  
		);
	}
}
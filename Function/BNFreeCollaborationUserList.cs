using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeCollaborationUserList(BNCollaborationUser** users, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeCollaborationUserList"
        )]
		internal static extern void BNFreeCollaborationUserList(
			
			// BNCollaborationUser** users
		    IntPtr users  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}
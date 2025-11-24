using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeCollaborationGroupList(BNCollaborationGroup** group, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeCollaborationGroupList"
        )]
		internal static extern void BNFreeCollaborationGroupList(
			
			// BNCollaborationGroup** _group
		    IntPtr _group  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}
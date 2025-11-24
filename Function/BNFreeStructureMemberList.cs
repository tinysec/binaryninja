using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeStructureMemberList(BNStructureMember* members, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeStructureMemberList"
        )]
		internal static extern void BNFreeStructureMemberList(
			
			// BNStructureMember* members
		    IntPtr members  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}
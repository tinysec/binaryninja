using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeEnumerationMemberList(BNEnumerationMember* members, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeEnumerationMemberList"
        )]
		internal static extern void BNFreeEnumerationMemberList(
			
			// BNEnumerationMember* members
		    IntPtr members  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}
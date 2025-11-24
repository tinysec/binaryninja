using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNEnumerationMember* BNGetEnumerationMembers(BNEnumeration* e, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetEnumerationMembers"
        )]
		internal static extern IntPtr BNGetEnumerationMembers(
			
			// BNEnumeration* e
		    IntPtr e  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
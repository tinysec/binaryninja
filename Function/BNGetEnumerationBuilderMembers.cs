using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNEnumerationMember* BNGetEnumerationBuilderMembers(BNEnumerationBuilder* e, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetEnumerationBuilderMembers"
        )]
		internal static extern IntPtr BNGetEnumerationBuilderMembers(
			
			// BNEnumerationBuilder* e
		    IntPtr e  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
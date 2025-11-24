using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeTypeFieldReferenceTypeInfo(BNTypeFieldReferenceTypeInfo* refs, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeTypeFieldReferenceTypeInfo"
        )]
		internal static extern void BNFreeTypeFieldReferenceTypeInfo(
			
			// BNTypeFieldReferenceTypeInfo* refs
		    IntPtr refs  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}
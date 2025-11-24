using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeTypeFieldReferenceTypes(BNTypeWithConfidence* refs, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeTypeFieldReferenceTypes"
        )]
		internal static extern void BNFreeTypeFieldReferenceTypes(
			
			// BNTypeWithConfidence* refs
		    IntPtr refs  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}
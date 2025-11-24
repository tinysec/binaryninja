using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeTypeReferences(BNTypeReferenceSource* refs, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeTypeReferences"
        )]
		internal static extern void BNFreeTypeReferences(
			
			// BNTypeReferenceSource* refs
		    IntPtr refs  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}
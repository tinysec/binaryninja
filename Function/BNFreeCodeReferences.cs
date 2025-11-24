using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeCodeReferences(BNReferenceSource* refs, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeCodeReferences"
        )]
		internal static extern void BNFreeCodeReferences(
			
			// BNReferenceSource* refs
		    IntPtr refs  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}
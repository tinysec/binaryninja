using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeILReferences(BNILReferenceSource* refs, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeILReferences"
        )]
		internal static extern void BNFreeILReferences(
			
			// BNILReferenceSource* refs
		    IntPtr refs  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTypeReferenceSource* BNGetCodeReferencesForTypeFrom(BNBinaryView* view, BNReferenceSource* addr, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetCodeReferencesForTypeFrom"
        )]
		internal static extern IntPtr BNGetCodeReferencesForTypeFrom(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNReferenceSource* addr
		    in BNReferenceSource addr  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
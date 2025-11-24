using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTypeReferenceSource* BNGetCodeReferencesForTypeFieldsFrom(BNBinaryView* view, BNReferenceSource* addr, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetCodeReferencesForTypeFieldsFrom"
        )]
		internal static extern IntPtr BNGetCodeReferencesForTypeFieldsFrom(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNReferenceSource* addr
		    in BNReferenceSource addr  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
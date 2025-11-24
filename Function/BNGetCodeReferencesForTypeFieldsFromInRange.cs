using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTypeReferenceSource* BNGetCodeReferencesForTypeFieldsFromInRange(BNBinaryView* view, BNReferenceSource* addr, uint64_t len, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetCodeReferencesForTypeFieldsFromInRange"
        )]
		internal static extern IntPtr BNGetCodeReferencesForTypeFieldsFromInRange(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNReferenceSource* addr
		    in BNReferenceSource addr  , 
			
			// uint64_t len
		    ulong len  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
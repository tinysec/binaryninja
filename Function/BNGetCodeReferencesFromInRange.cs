using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t* BNGetCodeReferencesFromInRange(BNBinaryView* view, BNReferenceSource* src, uint64_t len, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetCodeReferencesFromInRange"
        )]
		internal static extern IntPtr BNGetCodeReferencesFromInRange(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNReferenceSource* src
		    in BNReferenceSource src  , 
			
			// uint64_t len
		    ulong len  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
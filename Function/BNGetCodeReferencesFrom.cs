using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t* BNGetCodeReferencesFrom(BNBinaryView* view, BNReferenceSource* src, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetCodeReferencesFrom"
        )]
		internal static extern IntPtr BNGetCodeReferencesFrom(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNReferenceSource* src
		    in BNReferenceSource src  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
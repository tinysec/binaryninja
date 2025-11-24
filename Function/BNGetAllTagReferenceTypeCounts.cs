using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNGetAllTagReferenceTypeCounts(BNBinaryView* view, BNTagType*** tagTypes, uint64_t** counts, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetAllTagReferenceTypeCounts"
        )]
		internal static extern void BNGetAllTagReferenceTypeCounts(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNTagType*** tagTypes
		    IntPtr tagTypes  , 
			
			// uint64_t** counts
		    IntPtr counts  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}
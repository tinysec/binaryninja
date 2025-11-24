using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTagReference* BNGetAllTagReferencesOfType(BNBinaryView* view, BNTagType* tagType, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetAllTagReferencesOfType"
        )]
		internal static extern IntPtr BNGetAllTagReferencesOfType(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNTagType* tagType
		    IntPtr tagType  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}
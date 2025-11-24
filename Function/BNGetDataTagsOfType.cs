using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTag** BNGetDataTagsOfType(BNBinaryView* view, uint64_t addr, BNTagType* tagType, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetDataTagsOfType"
        )]
		internal static extern IntPtr BNGetDataTagsOfType(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// uint64_t addr
		    ulong addr  , 
			
			// BNTagType* tagType
		    IntPtr tagType  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}
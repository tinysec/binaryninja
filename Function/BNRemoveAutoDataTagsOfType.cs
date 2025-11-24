using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNRemoveAutoDataTagsOfType(BNBinaryView* view, uint64_t addr, BNTagType* tagType)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNRemoveAutoDataTagsOfType"
        )]
		internal static extern void BNRemoveAutoDataTagsOfType(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// uint64_t addr
		    ulong addr  , 
			
			// BNTagType* tagType
		    IntPtr tagType  
		);
	}
}
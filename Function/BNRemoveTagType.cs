using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNRemoveTagType(BNBinaryView* view, BNTagType* tagType)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNRemoveTagType"
        )]
		internal static extern void BNRemoveTagType(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNTagType* tagType
		    IntPtr tagType  
		);
	}
}
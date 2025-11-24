using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNAddTagType(BNBinaryView* view, BNTagType* tagType)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAddTagType"
        )]
		internal static extern void BNAddTagType(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNTagType* tagType
		    IntPtr tagType  
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNTagTypeSetType(BNTagType* tagType, BNTagTypeType type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNTagTypeSetType"
        )]
		internal static extern void BNTagTypeSetType(
			
			// BNTagType* tagType
		    IntPtr tagType  , 
			
			// BNTagTypeType type
		    TagTypeType type  
		);
	}
}
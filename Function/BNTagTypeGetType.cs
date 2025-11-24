using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTagTypeType BNTagTypeGetType(BNTagType* tagType)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNTagTypeGetType"
        )]
		internal static extern TagTypeType BNTagTypeGetType(
			
			// BNTagType* tagType
		    IntPtr tagType  
		);
	}
}
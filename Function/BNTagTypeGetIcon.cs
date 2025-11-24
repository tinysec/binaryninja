using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// char* BNTagTypeGetIcon(BNTagType* tagType)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNTagTypeGetIcon"
        )]
		internal static extern IntPtr BNTagTypeGetIcon(
			
			// BNTagType* tagType
		    IntPtr tagType  
		);
	}
}
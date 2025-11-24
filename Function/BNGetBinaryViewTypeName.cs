using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNGetBinaryViewTypeName(BNBinaryViewType* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetBinaryViewTypeName"
        )]
		internal static extern IntPtr BNGetBinaryViewTypeName(
			
			// BNBinaryViewType* type
		    IntPtr type  
			
		);
	}
}
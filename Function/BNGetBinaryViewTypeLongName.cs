using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNGetBinaryViewTypeLongName(BNBinaryViewType* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetBinaryViewTypeLongName"
        )]
		internal static extern IntPtr BNGetBinaryViewTypeLongName(
			
			// BNBinaryViewType* type
		    IntPtr type  
			
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeBinaryViewTypeList(BNBinaryViewType** types)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeBinaryViewTypeList"
        )]
		internal static extern void BNFreeBinaryViewTypeList(
			
			// BNBinaryViewType** types
		    IntPtr types  
		);
	}
}
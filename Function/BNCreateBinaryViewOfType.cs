using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNBinaryView* BNCreateBinaryViewOfType(BNBinaryViewType* type, BNBinaryView* data)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateBinaryViewOfType"
        )]
		internal static extern IntPtr BNCreateBinaryViewOfType(
			
			// BNBinaryViewType* type
		    IntPtr type  , 
			
			// BNBinaryView* data
		    IntPtr data  
		);
	}
}
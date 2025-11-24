using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNBinaryView* BNParseBinaryViewOfType(BNBinaryViewType* type, BNBinaryView* data)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNParseBinaryViewOfType"
        )]
		internal static extern IntPtr BNParseBinaryViewOfType(
			
			// BNBinaryViewType* type
		    IntPtr type  , 
			
			// BNBinaryView* data
		    IntPtr data  
			
		);
	}
}
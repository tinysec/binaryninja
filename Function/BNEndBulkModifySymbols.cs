using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNEndBulkModifySymbols(BNBinaryView* view)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNEndBulkModifySymbols"
        )]
		internal static extern void BNEndBulkModifySymbols(
			
			// BNBinaryView* view
		    IntPtr view  
		);
	}
}
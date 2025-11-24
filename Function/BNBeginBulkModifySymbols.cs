using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNBeginBulkModifySymbols(BNBinaryView* view)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNBeginBulkModifySymbols"
        )]
		internal static extern void BNBeginBulkModifySymbols(
			
			// BNBinaryView* view
		    IntPtr view  
		);
	}
}
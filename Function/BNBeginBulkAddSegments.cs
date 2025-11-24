using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNBeginBulkAddSegments(BNBinaryView* view)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNBeginBulkAddSegments"
        )]
		internal static extern void BNBeginBulkAddSegments(
			
			// BNBinaryView* view
		    IntPtr view  
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNCancelBulkAddSegments(BNBinaryView* view)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCancelBulkAddSegments"
        )]
		internal static extern void BNCancelBulkAddSegments(
			
			// BNBinaryView* view
		    IntPtr view  
		);
	}
}
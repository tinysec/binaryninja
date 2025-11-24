using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNBinaryView* BNGetReportView(BNReportCollection* reports, uint64_t i)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetReportView"
        )]
		internal static extern IntPtr BNGetReportView(
			
			// BNReportCollection* reports
		    IntPtr reports  , 
			
			// uint64_t i
		    ulong i  
		);
	}
}
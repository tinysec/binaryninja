using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// char* BNGetReportTitle(BNReportCollection* reports, uint64_t i)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetReportTitle"
        )]
		internal static extern IntPtr BNGetReportTitle(
			
			// BNReportCollection* reports
		    IntPtr reports  , 
			
			// uint64_t i
		    ulong i  
		);
	}
}
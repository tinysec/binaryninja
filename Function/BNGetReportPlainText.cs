using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// char* BNGetReportPlainText(BNReportCollection* reports, uint64_t i)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetReportPlainText"
        )]
		internal static extern IntPtr BNGetReportPlainText(
			
			// BNReportCollection* reports
		    IntPtr reports  , 
			
			// uint64_t i
		    ulong i  
		);
	}
}
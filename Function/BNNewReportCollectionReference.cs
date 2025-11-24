using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNReportCollection* BNNewReportCollectionReference(BNReportCollection* reports)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewReportCollectionReference"
        )]
		internal static extern IntPtr BNNewReportCollectionReference(
			
			// BNReportCollection* reports
		    IntPtr reports  
			
		);
	}
}
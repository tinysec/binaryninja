using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNGetTypePrinterName(BNTypePrinter* printer)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetTypePrinterName"
        )]
		internal static extern IntPtr BNGetTypePrinterName(
			
			// BNTypePrinter* printer
		    IntPtr printer  
			
		);
	}
}
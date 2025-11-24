using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetDefaultArchitecture(BNBinaryView* view, BNArchitecture* arch)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetDefaultArchitecture"
        )]
		internal static extern void BNSetDefaultArchitecture(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNArchitecture* arch
		    IntPtr arch  
			
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNCallingConvention* BNGetArchitectureFastcallCallingConvention(BNArchitecture* arch)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetArchitectureFastcallCallingConvention"
        )]
		internal static extern IntPtr BNGetArchitectureFastcallCallingConvention(
			
			// BNArchitecture* arch
		    IntPtr arch  
			
		);
	}
}
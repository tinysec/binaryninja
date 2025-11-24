using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetArchitectureFastcallCallingConvention(BNArchitecture* arch, BNCallingConvention* cc)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetArchitectureFastcallCallingConvention"
        )]
		internal static extern void BNSetArchitectureFastcallCallingConvention(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// BNCallingConvention* cc
		    IntPtr cc  
			
		);
	}
}
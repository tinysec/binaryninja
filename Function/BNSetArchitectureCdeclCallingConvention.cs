using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetArchitectureCdeclCallingConvention(BNArchitecture* arch, BNCallingConvention* cc)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetArchitectureCdeclCallingConvention"
        )]
		internal static extern void BNSetArchitectureCdeclCallingConvention(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// BNCallingConvention* cc
		    IntPtr cc  
			
		);
	}
}
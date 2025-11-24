using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNRegisterPlatformCdeclCallingConvention(BNPlatform* platform, BNCallingConvention* cc)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNRegisterPlatformCdeclCallingConvention"
        )]
		internal static extern void BNRegisterPlatformCdeclCallingConvention(
			
			// BNPlatform* platform
		    IntPtr platform  , 
			
			// BNCallingConvention* cc
		    IntPtr cc  
		);
	}
}
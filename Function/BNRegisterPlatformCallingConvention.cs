using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNRegisterPlatformCallingConvention(BNPlatform* platform, BNCallingConvention* cc)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNRegisterPlatformCallingConvention"
        )]
		internal static extern void BNRegisterPlatformCallingConvention(
			
			// BNPlatform* platform
		    IntPtr platform  , 
			
			// BNCallingConvention* cc
		    IntPtr cc  
		);
	}
}
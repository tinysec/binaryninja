using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNRegisterPlatformDefaultCallingConvention(BNPlatform* platform, BNCallingConvention* cc)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNRegisterPlatformDefaultCallingConvention"
        )]
		internal static extern void BNRegisterPlatformDefaultCallingConvention(
			
			// BNPlatform* platform
		    IntPtr platform  , 
			
			// BNCallingConvention* cc
		    IntPtr cc  
		);
	}
}
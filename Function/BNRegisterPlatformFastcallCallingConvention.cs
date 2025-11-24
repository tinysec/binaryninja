using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNRegisterPlatformFastcallCallingConvention(BNPlatform* platform, BNCallingConvention* cc)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNRegisterPlatformFastcallCallingConvention"
        )]
		internal static extern void BNRegisterPlatformFastcallCallingConvention(
			
			// BNPlatform* platform
		    IntPtr platform  , 
			
			// BNCallingConvention* cc
		    IntPtr cc  
		);
	}
}
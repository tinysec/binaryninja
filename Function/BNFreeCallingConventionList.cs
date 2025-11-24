using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeCallingConventionList(BNCallingConvention** list, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeCallingConventionList"
        )]
		internal static extern void BNFreeCallingConventionList(
			
			// BNCallingConvention** list
		    IntPtr list  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}
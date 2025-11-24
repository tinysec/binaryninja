using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// int64_t BNMaskToSize(int64_t value, uint64_t size)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNMaskToSize"
        )]
		internal static extern long BNMaskToSize(
			
			// int64_t _value
		    long _value  , 
			
			// uint64_t size
		    ulong size  
		);
	}
}
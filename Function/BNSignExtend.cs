using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// int64_t BNSignExtend(int64_t value, uint64_t sourceSize, uint64_t destSize)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSignExtend"
        )]
		internal static extern long BNSignExtend(
			
			// int64_t _value
		    long _value  , 
			
			// uint64_t sourceSize
		    ulong sourceSize  , 
			
			// uint64_t destSize
		    ulong destSize  
		);
	}
}
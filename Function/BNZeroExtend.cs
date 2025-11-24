using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// int64_t BNZeroExtend(int64_t value, uint64_t sourceSize, uint64_t destSize)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNZeroExtend"
        )]
		internal static extern long BNZeroExtend(
			
			// int64_t _value
		    long _value  , 
			
			// uint64_t sourceSize
		    ulong sourceSize  , 
			
			// uint64_t destSize
		    ulong destSize  
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNGetDisplayStringForInteger(BNBinaryView* binaryView, BNIntegerDisplayType type, uint64_t value, uint64_t inputWidth, bool isSigned)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetDisplayStringForInteger"
        )]
		internal static extern IntPtr BNGetDisplayStringForInteger(
			
			// BNBinaryView* binaryView
		    IntPtr binaryView  , 
			
			// BNIntegerDisplayType type
		    IntegerDisplayType type  , 
			
			// uint64_t _value
		    ulong _value  , 
			
			// uint64_t inputWidth
		    ulong inputWidth  , 
			
			// bool isSigned
		    bool isSigned  
			
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNInstructionTextToken* BNGetEnumerationTokensForValue(BNEnumeration* e, uint64_t value, uint64_t width, uint64_t* count, BNType* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetEnumerationTokensForValue"
        )]
		internal static extern IntPtr BNGetEnumerationTokensForValue(
			
			// BNEnumeration* e
		    IntPtr e  , 
			
			// uint64_t value
		    ulong value  , 
			
			// uint64_t width
		    ulong width  , 
			
			// uint64_t* count
		    out ulong count  , 
			
			// BNType* type
		    IntPtr type  
		);
	}
}
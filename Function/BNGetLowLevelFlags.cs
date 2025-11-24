using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint32_t* BNGetLowLevelFlags(BNLowLevelILFunction* func, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLowLevelFlags"
        )]
		internal static extern IntPtr BNGetLowLevelFlags(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t* BNGetLowLevelILSSAMemoryUses(BNLowLevelILFunction* func, uint64_t version, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLowLevelILSSAMemoryUses"
        )]
		internal static extern IntPtr BNGetLowLevelILSSAMemoryUses(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t version
		    ulong version  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
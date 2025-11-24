using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t* BNGetLowLevelILSSAFlagUses(BNLowLevelILFunction* func, uint32_t reg, uint64_t version, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLowLevelILSSAFlagUses"
        )]
		internal static extern IntPtr BNGetLowLevelILSSAFlagUses(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// uint32_t reg
			FlagIndex reg  , 
			
			// uint64_t version
		    ulong version  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
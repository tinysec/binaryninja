using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNPossibleValueSet BNGetCachedLowLevelILPossibleValueSet(BNLowLevelILFunction* func, uint64_t idx)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetCachedLowLevelILPossibleValueSet"
        )]
		internal static extern BNPossibleValueSet BNGetCachedLowLevelILPossibleValueSet(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t idx
			LowLevelILPossibleValueSetCacheIndex idx  
		);
	}
}
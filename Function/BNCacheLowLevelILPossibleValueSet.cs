using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNCacheLowLevelILPossibleValueSet(BNLowLevelILFunction* func, BNPossibleValueSet* pvs)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCacheLowLevelILPossibleValueSet"
        )]
		internal static extern LowLevelILPossibleValueSetCacheIndex BNCacheLowLevelILPossibleValueSet(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// BNPossibleValueSet* pvs
		    in BNPossibleValueSet pvs  
		);
	}
}
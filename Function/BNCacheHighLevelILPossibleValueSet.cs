using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNCacheHighLevelILPossibleValueSet(BNHighLevelILFunction* func, BNPossibleValueSet* pvs)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCacheHighLevelILPossibleValueSet"
        )]
		internal static extern HighLevelILPossibleValueSetCacheIndex BNCacheHighLevelILPossibleValueSet(
			
			// BNHighLevelILFunction* func
		    IntPtr func  , 
			
			// BNPossibleValueSet* pvs
		    in BNPossibleValueSet pvs  
		);
	}
}
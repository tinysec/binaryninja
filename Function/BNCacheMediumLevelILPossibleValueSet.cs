using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNCacheMediumLevelILPossibleValueSet(BNMediumLevelILFunction* func, BNPossibleValueSet* pvs)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCacheMediumLevelILPossibleValueSet"
        )]
		internal static extern MediumLevelILPossibleValueSetCacheIndex BNCacheMediumLevelILPossibleValueSet(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// BNPossibleValueSet* pvs
		    in BNPossibleValueSet pvs  
		);
	}
}
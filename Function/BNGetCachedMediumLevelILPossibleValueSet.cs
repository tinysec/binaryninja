using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNPossibleValueSet BNGetCachedMediumLevelILPossibleValueSet(BNMediumLevelILFunction* func, uint64_t idx)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetCachedMediumLevelILPossibleValueSet"
        )]
		internal static extern BNPossibleValueSet BNGetCachedMediumLevelILPossibleValueSet(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t idx
		    ulong idx  
		);
	}
}
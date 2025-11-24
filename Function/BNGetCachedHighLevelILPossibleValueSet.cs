using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNPossibleValueSet BNGetCachedHighLevelILPossibleValueSet(BNHighLevelILFunction* func, uint64_t idx)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetCachedHighLevelILPossibleValueSet"
        )]
		internal static extern BNPossibleValueSet BNGetCachedHighLevelILPossibleValueSet(
			
			// BNHighLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t idx
		    ulong idx  
			
		);
	}
}
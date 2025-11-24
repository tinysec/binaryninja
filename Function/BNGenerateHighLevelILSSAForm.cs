using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNGenerateHighLevelILSSAForm(BNHighLevelILFunction* func, BNVariable* aliases, uint64_t aliasCount)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGenerateHighLevelILSSAForm"
        )]
		internal static extern void BNGenerateHighLevelILSSAForm(
			
			// BNHighLevelILFunction* func
		    IntPtr func  , 
			
			// BNVariable* aliases
			BNVariable[] aliases  , 
			
			// uint64_t aliasCount
		    ulong aliasCount  
		);
	}
}
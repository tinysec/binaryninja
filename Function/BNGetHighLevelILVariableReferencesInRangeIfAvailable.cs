using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNVariableReferenceSource* BNGetHighLevelILVariableReferencesInRangeIfAvailable(BNFunction* func, BNArchitecture* arch, uint64_t address, uint64_t len, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetHighLevelILVariableReferencesInRangeIfAvailable"
        )]
		internal static extern IntPtr BNGetHighLevelILVariableReferencesInRangeIfAvailable(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint64_t address
		    ulong address  , 
			
			// uint64_t len
		    ulong len  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}
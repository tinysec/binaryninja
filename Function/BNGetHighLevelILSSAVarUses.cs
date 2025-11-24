using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t* BNGetHighLevelILSSAVarUses(BNHighLevelILFunction* func, BNVariable* var, uint64_t version, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetHighLevelILSSAVarUses"
        )]
		internal static extern IntPtr BNGetHighLevelILSSAVarUses(
			
			// BNHighLevelILFunction* func
		    IntPtr func  , 
			
			// BNVariable* _var
		    in BNVariable _var  , 
			
			// uint64_t version
		    ulong version  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t* BNGetMediumLevelILSSAVarUses(BNMediumLevelILFunction* func, BNVariable* var, uint64_t version, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetMediumLevelILSSAVarUses"
        )]
		internal static extern IntPtr BNGetMediumLevelILSSAVarUses(
			
			// BNMediumLevelILFunction* func
		    IntPtr function  , 
			
			// BNVariable* variable
		    in BNVariable variable  , 
			
			// uint64_t version
		    ulong version  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
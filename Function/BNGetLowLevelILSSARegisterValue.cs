using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRegisterValue BNGetLowLevelILSSARegisterValue(BNLowLevelILFunction* func, uint32_t reg, uint64_t version)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLowLevelILSSARegisterValue"
        )]
		internal static extern BNRegisterValue BNGetLowLevelILSSARegisterValue(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// uint32_t reg
			RegisterIndex reg  , 
			
			// uint64_t version
		    ulong version  
		);
	}
}
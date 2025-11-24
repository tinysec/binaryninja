using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetLowLevelILSSARegisterDefinition(BNLowLevelILFunction* func, uint32_t reg, uint64_t version)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLowLevelILSSARegisterDefinition"
        )]
		internal static extern LowLevelILInstructionIndex BNGetLowLevelILSSARegisterDefinition(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// uint32_t reg
		    RegisterIndex reg  , 
			
			// uint64_t version
		    ulong version  
		);
	}
}
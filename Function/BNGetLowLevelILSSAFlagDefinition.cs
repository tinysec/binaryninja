using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetLowLevelILSSAFlagDefinition(BNLowLevelILFunction* func, uint32_t reg, uint64_t version)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLowLevelILSSAFlagDefinition"
        )]
		internal static extern LowLevelILInstructionIndex BNGetLowLevelILSSAFlagDefinition(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// uint32_t reg
		    FlagIndex flag  , 
			
			// uint64_t version
		    ulong version  
		);
	}
}
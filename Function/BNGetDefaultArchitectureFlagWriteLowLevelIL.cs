using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetDefaultArchitectureFlagWriteLowLevelIL(BNArchitecture* arch, BNLowLevelILOperation op, uint64_t size, BNFlagRole role, BNRegisterOrConstant* operands, uint64_t operandCount, BNLowLevelILFunction* il)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetDefaultArchitectureFlagWriteLowLevelIL"
        )]
		internal static extern ulong BNGetDefaultArchitectureFlagWriteLowLevelIL(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// BNLowLevelILOperation op
		    LowLevelILOperation op  , 
			
			// uint64_t size
		    ulong size  , 
			
			// BNFlagRole role
		    FlagRole role  , 
			
			// BNRegisterOrConstant* operands
			BNRegisterOrConstant[] operands  , 
			
			// uint64_t operandCount
		    ulong operandCount  , 
			
			// BNLowLevelILFunction* il
		    IntPtr il  
		);
	}
}
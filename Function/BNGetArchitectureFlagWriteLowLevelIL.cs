using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetArchitectureFlagWriteLowLevelIL(BNArchitecture* arch, BNLowLevelILOperation op, uint64_t size, uint32_t flagWriteType, uint32_t flag, BNRegisterOrConstant* operands, uint64_t operandCount, BNLowLevelILFunction* il)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetArchitectureFlagWriteLowLevelIL"
        )]
		internal static extern ulong BNGetArchitectureFlagWriteLowLevelIL(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// BNLowLevelILOperation op
		    LowLevelILOperation op  , 
			
			// uint64_t size
		    ulong size  , 
			
			// uint32_t flagWriteType
		    uint flagWriteType  , 
			
			// uint32_t flag
		    uint flag  , 
			
			// BNRegisterOrConstant* operands
			BNRegisterOrConstant[] operands  , 
			
			// uint64_t operandCount
		    ulong operandCount  , 
			
			// BNLowLevelILFunction* il
		    IntPtr il  
		);
	}
}
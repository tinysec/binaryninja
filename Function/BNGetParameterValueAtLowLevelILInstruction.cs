using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRegisterValue BNGetParameterValueAtLowLevelILInstruction(BNFunction* func, uint64_t instr, BNType* functionType, uint64_t i)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetParameterValueAtLowLevelILInstruction"
        )]
		internal static extern BNRegisterValue BNGetParameterValueAtLowLevelILInstruction(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// uint64_t instr
		    ulong instr  , 
			
			// BNType* functionType
		    IntPtr functionType  , 
			
			// uint64_t i
		    ulong i  
		);
	}
}
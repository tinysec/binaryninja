using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNReplaceMediumLevelILInstruction(BNMediumLevelILFunction* func, uint64_t instr, uint64_t expr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNReplaceMediumLevelILInstruction"
        )]
		internal static extern void BNReplaceMediumLevelILInstruction(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t instr
		    ulong instr  , 
			
			// uint64_t expr
		    ulong expr  
			
		);
	}
}
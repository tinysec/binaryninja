using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNMediumLevelILGetInstructionStart(BNMediumLevelILFunction* func, BNArchitecture* arch, uint64_t addr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNMediumLevelILGetInstructionStart"
        )]
		internal static extern MediumLevelILInstructionIndex BNMediumLevelILGetInstructionStart(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint64_t addr
		    ulong addr  
		);
	}
}
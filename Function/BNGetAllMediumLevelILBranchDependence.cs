using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNILBranchInstructionAndDependence* BNGetAllMediumLevelILBranchDependence(BNMediumLevelILFunction* func, uint64_t instr, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetAllMediumLevelILBranchDependence"
        )]
		internal static extern IntPtr BNGetAllMediumLevelILBranchDependence(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t instr
			MediumLevelILInstructionIndex instr  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
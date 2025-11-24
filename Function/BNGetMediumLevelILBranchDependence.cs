using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNILBranchDependence BNGetMediumLevelILBranchDependence(BNMediumLevelILFunction* func, uint64_t curInstr, uint64_t branchInstr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetMediumLevelILBranchDependence"
        )]
		internal static extern ILBranchDependence BNGetMediumLevelILBranchDependence(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t curInstr
			MediumLevelILInstructionIndex curInstr  , 
			
			// uint64_t branchInstr
			MediumLevelILInstructionIndex branchInstr  
		);
	}
}
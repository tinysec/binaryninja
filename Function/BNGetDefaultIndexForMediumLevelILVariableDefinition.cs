using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint32_t BNGetDefaultIndexForMediumLevelILVariableDefinition(BNMediumLevelILFunction* func, BNVariable* var, uint64_t instrIndex)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetDefaultIndexForMediumLevelILVariableDefinition"
        )]
		internal static extern uint BNGetDefaultIndexForMediumLevelILVariableDefinition(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// BNVariable* _var
		    in BNVariable variable  , 
			
			// uint64_t instrIndex
			MediumLevelILInstructionIndex instrIndex  
		);
	}
}
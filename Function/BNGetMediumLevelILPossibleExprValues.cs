using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNPossibleValueSet BNGetMediumLevelILPossibleExprValues(BNMediumLevelILFunction* func, uint64_t expr, BNDataFlowQueryOption* options, uint64_t optionCount)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetMediumLevelILPossibleExprValues"
        )]
		internal static extern BNPossibleValueSet BNGetMediumLevelILPossibleExprValues(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t expr
			MediumLevelILExpressionIndex expression  , 
			
			// BNDataFlowQueryOption* options
			DataFlowQueryOption[] options  , 
			
			// uint64_t optionCount
		    ulong optionCount  
		);
	}
}
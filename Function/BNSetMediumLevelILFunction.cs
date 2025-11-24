using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetMediumLevelILFunction(BNAnalysisContext* analysisContext, BNMediumLevelILFunction* mediumLevelIL, uint64_t* llilSSAToMLILSSAInstrMap, uint64_t instrCount, BNExprMapInfo* llilSSAToMLILSSAExprMap, uint64_t exprCount)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetMediumLevelILFunction"
        )]
		internal static extern void BNSetMediumLevelILFunction(
			
			// BNAnalysisContext* analysisContext
		    IntPtr analysisContext  , 
			
			// BNMediumLevelILFunction* mediumLevelIL
		    IntPtr mediumLevelIL  , 
			
			// uint64_t* llilSSAToMLILSSAInstrMap
		    IntPtr llilSSAToMLILSSAInstrMap  , 
			
			// uint64_t instrCount
		    ulong instrCount  , 
			
			// BNExprMapInfo* llilSSAToMLILSSAExprMap
		    IntPtr llilSSAToMLILSSAExprMap  , 
			
			// uint64_t exprCount
		    ulong exprCount  
			
		);
	}
}
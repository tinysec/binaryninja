using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNMediumLevelILIf(BNMediumLevelILFunction* func, uint64_t op, BNMediumLevelILLabel* t, BNMediumLevelILLabel* f)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNMediumLevelILIf"
        )]
		internal static extern MediumLevelILExpressionIndex BNMediumLevelILIf(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t op
			MediumLevelILExpressionIndex op  , 
			
			// BNMediumLevelILLabel* t
		    in BNMediumLevelILLabel t  , 
			
			// BNMediumLevelILLabel* f
		    in BNMediumLevelILLabel f  
		);
	}
}
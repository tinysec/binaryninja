using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNMediumLevelILGoto(BNMediumLevelILFunction* func, BNMediumLevelILLabel* label)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNMediumLevelILGoto"
        )]
		internal static extern MediumLevelILExpressionIndex BNMediumLevelILGoto(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// BNMediumLevelILLabel* label
		    in BNMediumLevelILLabel label  
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNLowLevelILAddLabelMap(BNLowLevelILFunction* func, uint64_t* values, BNLowLevelILLabel** labels, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNLowLevelILAddLabelMap"
        )]
		internal static extern LowLevelILExpressionIndex BNLowLevelILAddLabelMap(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t* values
		    ulong[] values  , 
			
			// BNLowLevelILLabel** labels
			BNLowLevelILLabel[] labels  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}
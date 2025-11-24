using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t* BNGetLowLevelILExprIndexes(BNMediumLevelILFunction* func, uint64_t expr, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLowLevelILExprIndexes"
        )]
		internal static extern IntPtr BNGetLowLevelILExprIndexes(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t expr
			MediumLevelILExpressionIndex expr  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
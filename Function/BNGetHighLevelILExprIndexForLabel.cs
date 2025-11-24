using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetHighLevelILExprIndexForLabel(BNHighLevelILFunction* func, uint64_t label)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetHighLevelILExprIndexForLabel"
        )]
		internal static extern HighLevelILExpressionIndex BNGetHighLevelILExprIndexForLabel(
			
			// BNHighLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t label
		    ulong label  
		);
	}
}
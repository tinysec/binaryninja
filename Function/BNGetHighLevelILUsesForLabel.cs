using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t* BNGetHighLevelILUsesForLabel(BNHighLevelILFunction* func, uint64_t label, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetHighLevelILUsesForLabel"
        )]
		internal static extern IntPtr BNGetHighLevelILUsesForLabel(
			
			// BNHighLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t label
		    ulong label  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
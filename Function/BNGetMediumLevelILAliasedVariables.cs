using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNVariable* BNGetMediumLevelILAliasedVariables(BNMediumLevelILFunction* func, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetMediumLevelILAliasedVariables"
        )]
		internal static extern IntPtr BNGetMediumLevelILAliasedVariables(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
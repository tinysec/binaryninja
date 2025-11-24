using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeVariableFieldResolutions(BNVariableFieldResolutionInfo* result, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeVariableFieldResolutions"
        )]
		internal static extern void BNFreeVariableFieldResolutions(
			
			// BNVariableFieldResolutionInfo* result
		    IntPtr result  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}
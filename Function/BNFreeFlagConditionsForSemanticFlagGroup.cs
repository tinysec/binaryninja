using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeFlagConditionsForSemanticFlagGroup(BNFlagConditionForSemanticClass* conditions)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeFlagConditionsForSemanticFlagGroup"
        )]
		internal static extern void BNFreeFlagConditionsForSemanticFlagGroup(
			
			// BNFlagConditionForSemanticClass* conditions
		    IntPtr conditions  
			
		);
	}
}
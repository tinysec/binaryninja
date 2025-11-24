using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreePossibleValueSet(BNPossibleValueSet* value)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreePossibleValueSet"
        )]
		internal static extern void BNFreePossibleValueSet(
			
			// BNPossibleValueSet* value
		    in BNPossibleValueSet value  
		);
	}
}
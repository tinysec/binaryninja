using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeUserVariableValues(BNUserVariableValue* result)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeUserVariableValues"
        )]
		internal static extern void BNFreeUserVariableValues(
			
			// BNUserVariableValue* result
		    IntPtr result  
			
		);
	}
}
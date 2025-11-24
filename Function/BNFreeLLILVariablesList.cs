using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeLLILVariablesList(uint32_t* vars)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeLLILVariablesList"
        )]
		internal static extern void BNFreeLLILVariablesList(
			
			// uint32_t* vars
		    IntPtr vars  
			
		);
	}
}
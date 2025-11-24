using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNOffsetWithConfidence BNGetFunctionStackAdjustment(BNFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetFunctionStackAdjustment"
        )]
		internal static extern BNOffsetWithConfidence BNGetFunctionStackAdjustment(
			
			// BNFunction* func
		    IntPtr func  
			
		);
	}
}
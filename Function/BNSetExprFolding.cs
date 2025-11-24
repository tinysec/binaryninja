using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetExprFolding(BNFunction* func, uint64_t addr, BNExprFolding mode)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetExprFolding"
        )]
		internal static extern void BNSetExprFolding(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// uint64_t addr
		    ulong addr  , 
			
			// BNExprFolding mode
		    ExprFolding mode  
			
		);
	}
}
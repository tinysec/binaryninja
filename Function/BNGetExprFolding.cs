using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNExprFolding BNGetExprFolding(BNFunction* func, uint64_t addr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetExprFolding"
        )]
		internal static extern ExprFolding BNGetExprFolding(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// uint64_t addr
		    ulong addr  
			
		);
	}
}
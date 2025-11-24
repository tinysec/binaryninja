using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetFunctionVariableDeadStoreElimination(BNFunction* func, BNVariable* var, BNDeadStoreElimination mode)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetFunctionVariableDeadStoreElimination"
        )]
		internal static extern void BNSetFunctionVariableDeadStoreElimination(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNVariable* _var
		    IntPtr _var  , 
			
			// BNDeadStoreElimination mode
		    DeadStoreElimination mode  
			
		);
	}
}
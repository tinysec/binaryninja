using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// char* BNGetVariableNameOrDefault(BNFunction* func, BNVariable* var)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetVariableNameOrDefault"
        )]
		internal static extern IntPtr BNGetVariableNameOrDefault(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNVariable* _var
		    in BNVariable variable  
		);
	}
}
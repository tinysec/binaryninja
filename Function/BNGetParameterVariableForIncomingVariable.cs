using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNVariable BNGetParameterVariableForIncomingVariable(BNCallingConvention* cc, BNVariable* var, BNFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetParameterVariableForIncomingVariable"
        )]
		internal static extern BNVariable BNGetParameterVariableForIncomingVariable(
			
			// BNCallingConvention* cc
		    IntPtr cc  , 
			
			// BNVariable* _var
		    IntPtr _var  , 
			
			// BNFunction* func
		    IntPtr func  
			
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNVariable BNGetIncomingVariableForParameterVariable(BNCallingConvention* cc, BNVariable* var, BNFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetIncomingVariableForParameterVariable"
        )]
		internal static extern BNVariable BNGetIncomingVariableForParameterVariable(
			
			// BNCallingConvention* cc
		    IntPtr cc  , 
			
			// BNVariable* _var
		    IntPtr _var  , 
			
			// BNFunction* func
		    IntPtr func  
			
		);
	}
}
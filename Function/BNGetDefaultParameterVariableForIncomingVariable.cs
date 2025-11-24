using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNVariable BNGetDefaultParameterVariableForIncomingVariable(BNCallingConvention* cc, BNVariable* var)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetDefaultParameterVariableForIncomingVariable"
        )]
		internal static extern BNVariable BNGetDefaultParameterVariableForIncomingVariable(
			
			// BNCallingConvention* cc
		    IntPtr cc  , 
			
			// BNVariable* _var
		    IntPtr _var  
			
		);
	}
}
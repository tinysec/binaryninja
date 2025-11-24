using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetUserVariableValue(BNFunction* func, BNVariable* var, BNArchitectureAndAddress* defSite, bool after, BNPossibleValueSet* value)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetUserVariableValue"
        )]
		internal static extern void BNSetUserVariableValue(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNVariable* _var
			in BNVariable _var  , 
			
			// BNArchitectureAndAddress* defSite
			in BNArchitectureAndAddress defSite  , 
			
			// bool after
		    bool after  , 
			
			// BNPossibleValueSet* _value
			in BNPossibleValueSet _value  
		);
	}
}
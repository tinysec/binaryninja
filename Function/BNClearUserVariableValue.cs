using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNClearUserVariableValue(BNFunction* func, BNVariable* var, BNArchitectureAndAddress* defSite, bool after)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNClearUserVariableValue"
        )]
		internal static extern void BNClearUserVariableValue(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNVariable* _var
		    in BNVariable _var  , 
			
			// BNArchitectureAndAddress* defSite
		    in BNArchitectureAndAddress defSite  , 
			
			// bool after
		    bool after  
		);
	}
}
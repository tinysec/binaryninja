using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNClearFieldResolutionForVariableAt(BNFunction* func, BNVariable* var, BNArchitectureAndAddress* defSite)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNClearFieldResolutionForVariableAt"
        )]
		internal static extern void BNClearFieldResolutionForVariableAt(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNVariable* _var
		    IntPtr _var  , 
			
			// BNArchitectureAndAddress* defSite
		    IntPtr defSite  
		);
	}
}
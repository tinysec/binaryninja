using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNClearForcedVariableVersion(BNFunction* func, BNVariable* var, BNArchitectureAndAddress* defSite)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNClearForcedVariableVersion"
        )]
		internal static extern void BNClearForcedVariableVersion(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNVariable* _var
		    IntPtr _var  , 
			
			// BNArchitectureAndAddress* defSite
		    IntPtr defSite  
		);
	}
}
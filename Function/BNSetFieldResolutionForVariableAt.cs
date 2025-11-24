using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetFieldResolutionForVariableAt(BNFunction* func, BNVariable* var, BNArchitectureAndAddress* defSite, BNFieldResolutionInfo* info)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetFieldResolutionForVariableAt"
        )]
		internal static extern void BNSetFieldResolutionForVariableAt(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNVariable* _var
		    IntPtr _var  , 
			
			// BNArchitectureAndAddress* defSite
		    IntPtr defSite  , 
			
			// BNFieldResolutionInfo* info
		    IntPtr info  
			
		);
	}
}
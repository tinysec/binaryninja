using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// char* BNGetLastSeenVariableNameOrDefault(BNFunction* func, BNVariable* var)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLastSeenVariableNameOrDefault"
        )]
		internal static extern IntPtr BNGetLastSeenVariableNameOrDefault(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNVariable* _var
		    in BNVariable _var  
		);
	}
}
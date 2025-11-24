using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNAddDebugDataVariableInfo(BNDebugInfo* debugInfo, BNDataVariableAndName* var)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAddDebugDataVariableInfo"
        )]
		internal static extern bool BNAddDebugDataVariableInfo(
			
			// BNDebugInfo* debugInfo
		    IntPtr debugInfo  , 
			
			// BNDataVariableAndName* _var
		    IntPtr _var  
		);
	}
}
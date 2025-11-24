using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeDataVariableAndName(BNDataVariableAndName* var)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeDataVariableAndName"
        )]
		internal static extern void BNFreeDataVariableAndName(
			
			// BNDataVariableAndName* _var
		    IntPtr _var  
			
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeVariableNameAndType(BNVariableNameAndType* var)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeVariableNameAndType"
        )]
		internal static extern void BNFreeVariableNameAndType(
			
			// BNVariableNameAndType* _var
		    IntPtr _var  
			
		);
	}
}
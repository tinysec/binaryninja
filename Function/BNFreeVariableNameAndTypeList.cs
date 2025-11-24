using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeVariableNameAndTypeList(BNVariableNameAndType* vars, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeVariableNameAndTypeList"
        )]
		internal static extern void BNFreeVariableNameAndTypeList(
			
			// BNVariableNameAndType* vars
		    IntPtr vars  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}
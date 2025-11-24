using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNAreArgumentRegistersUsedForVarArgs(BNCallingConvention* cc)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAreArgumentRegistersUsedForVarArgs"
        )]
		internal static extern bool BNAreArgumentRegistersUsedForVarArgs(
			
			// BNCallingConvention* cc
		    IntPtr cc  
		);
	}
}
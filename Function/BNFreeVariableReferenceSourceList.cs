using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeVariableReferenceSourceList(BNVariableReferenceSource* vars, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeVariableReferenceSourceList"
        )]
		internal static extern void BNFreeVariableReferenceSourceList(
			
			// BNVariableReferenceSource* vars
		    IntPtr vars  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}
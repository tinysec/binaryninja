using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeDataVariable(BNDataVariable* var)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeDataVariable"
        )]
		internal static extern void BNFreeDataVariable(
			
			// BNDataVariable* _var
		    in BNDataVariable _var 
		);
	}
}
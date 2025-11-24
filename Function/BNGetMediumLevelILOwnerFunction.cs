using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNFunction* BNGetMediumLevelILOwnerFunction(BNMediumLevelILFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetMediumLevelILOwnerFunction"
        )]
		internal static extern IntPtr BNGetMediumLevelILOwnerFunction(
			
			// BNMediumLevelILFunction* func
		    IntPtr function 
		);
	}
}
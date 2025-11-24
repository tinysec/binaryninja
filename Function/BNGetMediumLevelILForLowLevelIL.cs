using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNMediumLevelILFunction* BNGetMediumLevelILForLowLevelIL(BNLowLevelILFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetMediumLevelILForLowLevelIL"
        )]
		internal static extern IntPtr BNGetMediumLevelILForLowLevelIL(
			
			// BNLowLevelILFunction* func
		    IntPtr func  
		);
	}
}
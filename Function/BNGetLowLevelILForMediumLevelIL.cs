using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLowLevelILFunction* BNGetLowLevelILForMediumLevelIL(BNMediumLevelILFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLowLevelILForMediumLevelIL"
        )]
		internal static extern IntPtr BNGetLowLevelILForMediumLevelIL(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  
		);
	}
}
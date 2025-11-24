using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNLowLevelILGetCurrentAddress(BNLowLevelILFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNLowLevelILGetCurrentAddress"
        )]
		internal static extern ulong BNLowLevelILGetCurrentAddress(
			
			// BNLowLevelILFunction* func
		    IntPtr func  
		);
	}
}
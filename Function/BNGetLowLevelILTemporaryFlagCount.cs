using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint32_t BNGetLowLevelILTemporaryFlagCount(BNLowLevelILFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLowLevelILTemporaryFlagCount"
        )]
		internal static extern uint BNGetLowLevelILTemporaryFlagCount(
			
			// BNLowLevelILFunction* func
		    IntPtr func  
		);
	}
}
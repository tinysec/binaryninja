using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNMediumLevelILFunction* BNGetMappedMediumLevelIL(BNLowLevelILFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetMappedMediumLevelIL"
        )]
		internal static extern IntPtr BNGetMappedMediumLevelIL(
			
			// BNLowLevelILFunction* func
		    IntPtr func  
		);
	}
}
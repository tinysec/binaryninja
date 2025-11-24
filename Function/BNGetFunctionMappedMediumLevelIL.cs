using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNMediumLevelILFunction* BNGetFunctionMappedMediumLevelIL(BNFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetFunctionMappedMediumLevelIL"
        )]
		internal static extern IntPtr BNGetFunctionMappedMediumLevelIL(
			
			// BNFunction* func
		    IntPtr func  
			
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLowLevelILFunction* BNNewLowLevelILFunctionReference(BNLowLevelILFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewLowLevelILFunctionReference"
        )]
		internal static extern IntPtr BNNewLowLevelILFunctionReference(
			
			// BNLowLevelILFunction* func
		    IntPtr func  
			
		);
	}
}
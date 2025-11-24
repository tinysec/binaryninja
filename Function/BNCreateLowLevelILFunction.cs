using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLowLevelILFunction* BNCreateLowLevelILFunction(BNArchitecture* arch, BNFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateLowLevelILFunction"
        )]
		internal static extern IntPtr BNCreateLowLevelILFunction(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// BNFunction* func
		    IntPtr func  
		);
	}
}
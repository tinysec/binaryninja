using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNMediumLevelILFunction* BNCreateMediumLevelILFunction(BNArchitecture* arch, BNFunction* func, BNLowLevelILFunction* lowLevelIL)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateMediumLevelILFunction"
        )]
		internal static extern IntPtr BNCreateMediumLevelILFunction(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNLowLevelILFunction* lowLevelIL
		    IntPtr lowLevelIL  
		);
	}
}
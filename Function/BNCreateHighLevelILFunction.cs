using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNHighLevelILFunction* BNCreateHighLevelILFunction(BNArchitecture* arch, BNFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateHighLevelILFunction"
        )]
		internal static extern IntPtr BNCreateHighLevelILFunction(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// BNFunction* func
		    IntPtr func  
		);
	}
}
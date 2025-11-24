using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNMediumLevelILSetCurrentAddress(BNMediumLevelILFunction* func, BNArchitecture* arch, uint64_t addr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNMediumLevelILSetCurrentAddress"
        )]
		internal static extern void BNMediumLevelILSetCurrentAddress(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint64_t addr
		    ulong addr  
		);
	}
}
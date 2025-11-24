using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint32_t* BNGetArchitectureFlagsRequiredForFlagCondition(BNArchitecture* arch, BNLowLevelILFlagCondition cond, uint32_t semClass, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetArchitectureFlagsRequiredForFlagCondition"
        )]
		internal static extern IntPtr BNGetArchitectureFlagsRequiredForFlagCondition(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// BNLowLevelILFlagCondition cond
		    LowLevelILFlagCondition cond  , 
			
			// uint32_t semClass
		    uint semClass  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
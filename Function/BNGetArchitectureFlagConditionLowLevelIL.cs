using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetArchitectureFlagConditionLowLevelIL(BNArchitecture* arch, BNLowLevelILFlagCondition cond, uint32_t semClass, BNLowLevelILFunction* il)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetArchitectureFlagConditionLowLevelIL"
        )]
		internal static extern ulong BNGetArchitectureFlagConditionLowLevelIL(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// BNLowLevelILFlagCondition cond
		    LowLevelILFlagCondition cond  , 
			
			// uint32_t semClass
		    uint semClass  , 
			
			// BNLowLevelILFunction* il
		    IntPtr il  
		);
	}
}
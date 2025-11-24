using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetArchitectureSemanticFlagGroupLowLevelIL(BNArchitecture* arch, uint32_t semGroup, BNLowLevelILFunction* il)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetArchitectureSemanticFlagGroupLowLevelIL"
        )]
		internal static extern ulong BNGetArchitectureSemanticFlagGroupLowLevelIL(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint32_t semGroup
		    uint semGroup  , 
			
			// BNLowLevelILFunction* il
		    IntPtr il  
		);
	}
}
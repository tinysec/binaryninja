using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetLowLevelILSSAMemoryDefinition(BNLowLevelILFunction* func, uint64_t version)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLowLevelILSSAMemoryDefinition"
        )]
		internal static extern LowLevelILInstructionIndex BNGetLowLevelILSSAMemoryDefinition(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t version
		    ulong version  
		);
	}
}
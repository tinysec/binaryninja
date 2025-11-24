using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetMediumLevelILSSAMemoryDefinition(BNMediumLevelILFunction* func, uint64_t version)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetMediumLevelILSSAMemoryDefinition"
        )]
		internal static extern MediumLevelILInstructionIndex BNGetMediumLevelILSSAMemoryDefinition(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t version
		    ulong version  
		);
	}
}
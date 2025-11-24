using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNPluginCommand* BNGetValidPluginCommandsForLowLevelILInstruction(BNBinaryView* view, BNLowLevelILFunction* func, uint64_t instr, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetValidPluginCommandsForLowLevelILInstruction"
        )]
		internal static extern IntPtr BNGetValidPluginCommandsForLowLevelILInstruction(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t instr
		    ulong instr  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
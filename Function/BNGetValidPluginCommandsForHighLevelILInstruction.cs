using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNPluginCommand* BNGetValidPluginCommandsForHighLevelILInstruction(BNBinaryView* view, BNHighLevelILFunction* func, uint64_t instr, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetValidPluginCommandsForHighLevelILInstruction"
        )]
		internal static extern IntPtr BNGetValidPluginCommandsForHighLevelILInstruction(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNHighLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t instr
		    ulong instr  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
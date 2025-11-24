using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNInstructionTextToken* BNUndoActionGetSummary(BNUndoAction* action, uint64_t* tokenCount)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNUndoActionGetSummary"
        )]
		internal static extern IntPtr BNUndoActionGetSummary(
			
			// BNUndoAction* action
		    IntPtr action  , 
			
			// uint64_t* tokenCount
		    IntPtr tokenCount  
			
		);
	}
}
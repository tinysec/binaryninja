using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint8_t* BNBasicBlockGetInstructionData(BNBasicBlock* block, uint64_t addr, uint64_t* len)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNBasicBlockGetInstructionData"
        )]
		internal static extern IntPtr BNBasicBlockGetInstructionData(
			
			// BNBasicBlock* block
		    IntPtr block  , 
			
			// uint64_t addr
		    ulong addr  , 
			
			// uint64_t* len
		    out ulong len  
		);
	}
}
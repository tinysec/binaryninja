using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNLowLevelILFreeOperandList(uint64_t* operands)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNLowLevelILFreeOperandList"
        )]
		internal static extern void BNLowLevelILFreeOperandList(
			
			// uint64_t* operands
		    IntPtr operands  
			
		);
	}
}
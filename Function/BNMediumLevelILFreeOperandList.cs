using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNMediumLevelILFreeOperandList(uint64_t* operands)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNMediumLevelILFreeOperandList"
        )]
		internal static extern void BNMediumLevelILFreeOperandList(
			
			// uint64_t* operands
		    IntPtr operands  
		);
	}
}
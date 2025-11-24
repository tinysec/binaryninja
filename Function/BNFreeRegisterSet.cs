using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeRegisterSet(BNRegisterSetWithConfidence* regs)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeRegisterSet"
        )]
		internal static extern void BNFreeRegisterSet(
			
			// BNRegisterSetWithConfidence* regs
		    IntPtr regs  
			
		);
	}
}
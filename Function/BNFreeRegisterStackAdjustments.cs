using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeRegisterStackAdjustments(BNRegisterStackAdjustment* adjustments)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeRegisterStackAdjustments"
        )]
		internal static extern void BNFreeRegisterStackAdjustments(
			
			// BNRegisterStackAdjustment* adjustments
		    IntPtr adjustments  
			
		);
	}
}
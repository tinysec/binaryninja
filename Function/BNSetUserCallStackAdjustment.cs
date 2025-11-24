using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetUserCallStackAdjustment(BNFunction* func, BNArchitecture* arch, uint64_t addr, int64_t adjust, uint8_t confidence)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetUserCallStackAdjustment"
        )]
		internal static extern void BNSetUserCallStackAdjustment(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint64_t addr
		    ulong addr  , 
			
			// int64_t adjust
		    long adjust  , 
			
			// uint8_t confidence
		    byte confidence  
			
		);
	}
}
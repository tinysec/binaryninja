using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetAutoCallRegisterStackAdjustmentForRegisterStack(BNFunction* func, BNArchitecture* arch, uint64_t addr, uint32_t regStack, int32_t adjust, uint8_t confidence)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetAutoCallRegisterStackAdjustmentForRegisterStack"
        )]
		internal static extern void BNSetAutoCallRegisterStackAdjustmentForRegisterStack(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint64_t addr
		    ulong addr  , 
			
			// uint32_t regStack
		    uint regStack  , 
			
			// int32_t adjust
		    int adjust  , 
			
			// uint8_t confidence
		    byte confidence  
			
		);
	}
}
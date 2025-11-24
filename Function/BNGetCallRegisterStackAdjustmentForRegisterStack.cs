using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRegisterStackAdjustment BNGetCallRegisterStackAdjustmentForRegisterStack(BNFunction* func, BNArchitecture* arch, uint64_t addr, uint32_t regStack)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetCallRegisterStackAdjustmentForRegisterStack"
        )]
		internal static extern BNRegisterStackAdjustment BNGetCallRegisterStackAdjustmentForRegisterStack(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint64_t addr
		    ulong addr  , 
			
			// uint32_t regStack
		    uint regStack  
			
		);
	}
}
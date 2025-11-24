using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetSwitchRecovery(BNFunction* func, uint64_t addr, BNSwitchRecovery mode)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetSwitchRecovery"
        )]
		internal static extern void BNSetSwitchRecovery(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// uint64_t addr
		    ulong addr  , 
			
			// BNSwitchRecovery mode
		    SwitchRecovery mode  
			
		);
	}
}
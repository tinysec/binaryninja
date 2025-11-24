using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNSwitchRecovery BNGetSwitchRecovery(BNFunction* func, uint64_t addr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetSwitchRecovery"
        )]
		internal static extern SwitchRecovery BNGetSwitchRecovery(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// uint64_t addr
		    ulong addr  
			
		);
	}
}
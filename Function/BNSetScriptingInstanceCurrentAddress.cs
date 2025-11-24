using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetScriptingInstanceCurrentAddress(BNScriptingInstance* instance, uint64_t addr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetScriptingInstanceCurrentAddress"
        )]
		internal static extern void BNSetScriptingInstanceCurrentAddress(
			
			// BNScriptingInstance* instance
		    IntPtr instance  , 
			
			// uint64_t addr
		    ulong addr  
			
		);
	}
}
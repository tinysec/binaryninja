using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeSystemCallList(BNSystemCallInfo* syscalls, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeSystemCallList"
        )]
		internal static extern void BNFreeSystemCallList(
			
			// BNSystemCallInfo* syscalls
		    IntPtr syscalls  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNRemoveUserCodeReference(BNFunction* func, BNArchitecture* fromArch, uint64_t fromAddr, uint64_t toAddr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNRemoveUserCodeReference"
        )]
		internal static extern void BNRemoveUserCodeReference(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNArchitecture* fromArch
		    IntPtr fromArch  , 
			
			// uint64_t fromAddr
		    ulong fromAddr  , 
			
			// uint64_t toAddr
		    ulong toAddr  
		);
	}
}
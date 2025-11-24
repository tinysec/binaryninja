using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNAddUserTypeReference(BNFunction* func, BNArchitecture* fromArch, uint64_t fromAddr, BNQualifiedName* name)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAddUserTypeReference"
        )]
		internal static extern void BNAddUserTypeReference(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNArchitecture* fromArch
		    IntPtr fromArch  , 
			
			// uint64_t fromAddr
		    ulong fromAddr  , 
			
			// BNQualifiedName* name
		    IntPtr name  
		);
	}
}
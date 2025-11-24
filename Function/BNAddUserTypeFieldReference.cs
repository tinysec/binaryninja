using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNAddUserTypeFieldReference(BNFunction* func, BNArchitecture* fromArch, uint64_t fromAddr, BNQualifiedName* name, uint64_t offset, uint64_t size)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAddUserTypeFieldReference"
        )]
		internal static extern void BNAddUserTypeFieldReference(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNArchitecture* fromArch
		    IntPtr fromArch  , 
			
			// uint64_t fromAddr
		    ulong fromAddr  , 
			
			// BNQualifiedName* name
		    IntPtr name  , 
			
			// uint64_t offset
		    ulong offset  , 
			
			// uint64_t size
		    ulong size  
		);
	}
}
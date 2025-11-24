using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTagReference* BNGetUserAddressTagReferences(BNFunction* func, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetUserAddressTagReferences"
        )]
		internal static extern IntPtr BNGetUserAddressTagReferences(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}
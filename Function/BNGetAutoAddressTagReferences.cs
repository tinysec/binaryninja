using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTagReference* BNGetAutoAddressTagReferences(BNFunction* func, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetAutoAddressTagReferences"
        )]
		internal static extern IntPtr BNGetAutoAddressTagReferences(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}
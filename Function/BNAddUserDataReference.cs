using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNAddUserDataReference(BNBinaryView* view, uint64_t fromAddr, uint64_t toAddr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAddUserDataReference"
        )]
		internal static extern void BNAddUserDataReference(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// uint64_t fromAddr
		    ulong fromAddr  , 
			
			// uint64_t toAddr
		    ulong toAddr  
		);
	}
}
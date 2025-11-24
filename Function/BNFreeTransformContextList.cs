using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeTransformContextList(BNTransformContext** contexts, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeTransformContextList"
        )]
		internal static extern void BNFreeTransformContextList(
			
			// BNTransformContext** contexts
		    IntPtr contexts  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}
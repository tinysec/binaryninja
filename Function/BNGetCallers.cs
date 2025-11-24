using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNReferenceSource* BNGetCallers(BNBinaryView* view, uint64_t callee, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetCallers"
        )]
		internal static extern IntPtr BNGetCallers(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// uint64_t callee
		    ulong callee  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
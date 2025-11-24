using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNAddAutoDataTag(BNBinaryView* view, uint64_t addr, BNTag* tag)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAddAutoDataTag"
        )]
		internal static extern void BNAddAutoDataTag(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// uint64_t addr
		    ulong addr  , 
			
			// BNTag* tag
		    IntPtr tag  
		);
	}
}
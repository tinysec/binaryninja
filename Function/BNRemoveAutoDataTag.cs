using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNRemoveAutoDataTag(BNBinaryView* view, uint64_t addr, BNTag* tag)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNRemoveAutoDataTag"
        )]
		internal static extern void BNRemoveAutoDataTag(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// uint64_t addr
		    ulong addr  , 
			
			// BNTag* tag
		    IntPtr tag  
		);
	}
}
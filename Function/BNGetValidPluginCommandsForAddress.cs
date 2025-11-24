using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNPluginCommand* BNGetValidPluginCommandsForAddress(BNBinaryView* view, uint64_t addr, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetValidPluginCommandsForAddress"
        )]
		internal static extern IntPtr BNGetValidPluginCommandsForAddress(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// uint64_t addr
		    ulong address  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
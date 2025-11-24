using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNPluginCommand* BNGetValidPluginCommandsForLowLevelILFunction(BNBinaryView* view, BNLowLevelILFunction* func, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetValidPluginCommandsForLowLevelILFunction"
        )]
		internal static extern IntPtr BNGetValidPluginCommandsForLowLevelILFunction(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNFunction* BNGetAnalysisFunction(BNBinaryView* view, BNPlatform* platform, uint64_t addr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetAnalysisFunction"
        )]
		internal static extern IntPtr BNGetAnalysisFunction(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNPlatform* platform
		    IntPtr platform  , 
			
			// uint64_t addr
		    ulong addr  
		);
	}
}
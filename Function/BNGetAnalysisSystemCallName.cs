using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// char* BNGetAnalysisSystemCallName(BNBinaryView* view, BNPlatform* platform, uint32_t id)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetAnalysisSystemCallName"
        )]
		internal static extern IntPtr BNGetAnalysisSystemCallName(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNPlatform* platform
		    IntPtr platform  , 
			
			// uint32_t id
		    uint id  
		);
	}
}
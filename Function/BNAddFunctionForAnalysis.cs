using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNFunction* BNAddFunctionForAnalysis(BNBinaryView* view, BNPlatform* platform, uint64_t addr, bool autoDiscovered, BNType* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAddFunctionForAnalysis"
        )]
		internal static extern IntPtr BNAddFunctionForAnalysis(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNPlatform* platform
		    IntPtr platform  , 
			
			// uint64_t addr
		    ulong addr  , 
			
			// bool autoDiscovered
		    bool autoDiscovered  , 
			
			// BNType* type
		    IntPtr type  
		);
	}
}
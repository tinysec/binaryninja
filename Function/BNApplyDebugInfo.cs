using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNApplyDebugInfo(BNBinaryView* view, BNDebugInfo* newDebugInfo)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNApplyDebugInfo"
        )]
		internal static extern void BNApplyDebugInfo(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNDebugInfo* newDebugInfo
		    IntPtr newDebugInfo  
		);
	}
}
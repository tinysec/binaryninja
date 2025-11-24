using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetDebugInfo(BNBinaryView* view, BNDebugInfo* newDebugInfo)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetDebugInfo"
        )]
		internal static extern void BNSetDebugInfo(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNDebugInfo* newDebugInfo
		    IntPtr newDebugInfo  
		);
	}
}
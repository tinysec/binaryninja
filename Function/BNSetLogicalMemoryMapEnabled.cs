using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetLogicalMemoryMapEnabled(BNBinaryView* view, bool enabled)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetLogicalMemoryMapEnabled"
        )]
		internal static extern void BNSetLogicalMemoryMapEnabled(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// bool enabled
		    bool enabled  
		);
	}
}
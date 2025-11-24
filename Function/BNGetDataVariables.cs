using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDataVariable* BNGetDataVariables(BNBinaryView* view, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetDataVariables"
        )]
		internal static extern IntPtr BNGetDataVariables(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
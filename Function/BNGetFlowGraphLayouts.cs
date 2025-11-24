using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNFlowGraphLayout** BNGetFlowGraphLayouts(uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetFlowGraphLayouts"
        )]
		internal static extern IntPtr BNGetFlowGraphLayouts(
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}
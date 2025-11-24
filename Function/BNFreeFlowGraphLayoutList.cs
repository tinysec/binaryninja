using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeFlowGraphLayoutList(BNFlowGraphLayout** layouts)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeFlowGraphLayoutList"
        )]
		internal static extern void BNFreeFlowGraphLayoutList(
			
			// BNFlowGraphLayout** layouts
		    IntPtr layouts  
			
		);
	}
}
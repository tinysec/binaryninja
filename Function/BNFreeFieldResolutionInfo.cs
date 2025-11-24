using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeFieldResolutionInfo(BNFieldResolutionInfo* info)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeFieldResolutionInfo"
        )]
		internal static extern void BNFreeFieldResolutionInfo(
			
			// BNFieldResolutionInfo* info
		    IntPtr info  
			
		);
	}
}
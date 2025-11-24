using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetOriginalImageBase(BNBinaryView* view, uint64_t imageBase)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetOriginalImageBase"
        )]
		internal static extern void BNSetOriginalImageBase(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// uint64_t imageBase
		    ulong imageBase  
			
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetGuidedSourceBlocks(BNFunction* func, BNArchitectureAndAddress* addresses, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetGuidedSourceBlocks"
        )]
		internal static extern void BNSetGuidedSourceBlocks(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNArchitectureAndAddress* addresses
		    IntPtr addresses  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}
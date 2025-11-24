using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNRemoveGuidedSourceBlocks(BNFunction* func, BNArchitectureAndAddress* addresses, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRemoveGuidedSourceBlocks"
        )]
		internal static extern void BNRemoveGuidedSourceBlocks(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNArchitectureAndAddress* addresses
		    IntPtr addresses  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}
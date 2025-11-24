using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNArchitectureAndAddress* BNGetGuidedSourceBlocks(BNFunction* func, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetGuidedSourceBlocks"
        )]
		internal static extern IntPtr BNGetGuidedSourceBlocks(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}
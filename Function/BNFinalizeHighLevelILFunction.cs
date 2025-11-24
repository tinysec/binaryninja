using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFinalizeHighLevelILFunction(BNHighLevelILFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFinalizeHighLevelILFunction"
        )]
		internal static extern void BNFinalizeHighLevelILFunction(
			
			// BNHighLevelILFunction* func
		    IntPtr func  
			
		);
	}
}
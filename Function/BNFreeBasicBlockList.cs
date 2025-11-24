using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeBasicBlockList(BNBasicBlock** blocks, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeBasicBlockList"
        )]
		internal static extern void BNFreeBasicBlockList(
			
			// BNBasicBlock** blocks
		    IntPtr blocks  , 
			
			// uint64_t count
		    ulong count  
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetBasicBlockEnd(BNBasicBlock* block, uint64_t end)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetBasicBlockEnd"
        )]
		internal static extern void BNSetBasicBlockEnd(
			
			// BNBasicBlock* block
		    IntPtr block  , 
			
			// uint64_t end
		    ulong end  
		);
	}
}
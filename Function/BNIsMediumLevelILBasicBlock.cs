using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNIsMediumLevelILBasicBlock(BNBasicBlock* block)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNIsMediumLevelILBasicBlock"
        )]
		internal static extern bool BNIsMediumLevelILBasicBlock(
			
			// BNBasicBlock* block
		    IntPtr block  
		);
	}
}
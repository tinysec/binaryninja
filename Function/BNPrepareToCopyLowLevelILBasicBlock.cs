using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNPrepareToCopyLowLevelILBasicBlock(BNLowLevelILFunction* func, BNBasicBlock* block)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNPrepareToCopyLowLevelILBasicBlock"
        )]
		internal static extern void BNPrepareToCopyLowLevelILBasicBlock(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// BNBasicBlock* block
		    IntPtr block  
		);
	}
}
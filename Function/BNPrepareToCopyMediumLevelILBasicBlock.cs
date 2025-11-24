using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNPrepareToCopyMediumLevelILBasicBlock(BNMediumLevelILFunction* func, BNBasicBlock* block)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNPrepareToCopyMediumLevelILBasicBlock"
        )]
		internal static extern void BNPrepareToCopyMediumLevelILBasicBlock(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// BNBasicBlock* block
		    IntPtr block  
		);
	}
}
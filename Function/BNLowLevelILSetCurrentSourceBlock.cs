using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNLowLevelILSetCurrentSourceBlock(BNLowLevelILFunction* func, BNBasicBlock* source)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNLowLevelILSetCurrentSourceBlock"
        )]
		internal static extern void BNLowLevelILSetCurrentSourceBlock(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// BNBasicBlock* source
		    IntPtr source  
		);
	}
}
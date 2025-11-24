using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNPrepareToCopyLowLevelILFunction(BNLowLevelILFunction* func, BNLowLevelILFunction* src)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNPrepareToCopyLowLevelILFunction"
        )]
		internal static extern void BNPrepareToCopyLowLevelILFunction(
			
			// BNLowLevelILFunction* func
		    IntPtr func  , 
			
			// BNLowLevelILFunction* src
		    IntPtr src  
		);
	}
}
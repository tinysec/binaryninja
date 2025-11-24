using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNPrepareToCopyMediumLevelILFunction(BNMediumLevelILFunction* func, BNMediumLevelILFunction* src)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNPrepareToCopyMediumLevelILFunction"
        )]
		internal static extern void BNPrepareToCopyMediumLevelILFunction(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// BNMediumLevelILFunction* src
		    IntPtr src  
		);
	}
}
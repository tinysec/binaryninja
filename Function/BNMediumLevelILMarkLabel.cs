using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNMediumLevelILMarkLabel(BNMediumLevelILFunction* func, BNMediumLevelILLabel* label)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNMediumLevelILMarkLabel"
        )]
		internal static extern void BNMediumLevelILMarkLabel(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// BNMediumLevelILLabel* label
		    in BNMediumLevelILLabel label  
		);
	}
}
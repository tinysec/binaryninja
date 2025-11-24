using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNLowLevelILInitLabel(BNLowLevelILLabel* label)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNLowLevelILInitLabel"
        )]
		internal static extern void BNLowLevelILInitLabel(
			
			// BNLowLevelILLabel* label
		    ref BNLowLevelILLabel label  
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNMediumLevelILInitLabel(BNMediumLevelILLabel* label)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNMediumLevelILInitLabel"
        )]
		internal static extern void BNMediumLevelILInitLabel(
			
			// BNMediumLevelILLabel* label
		    ref BNMediumLevelILLabel label  
		);
	}
}
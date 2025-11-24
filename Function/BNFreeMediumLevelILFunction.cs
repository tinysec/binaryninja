using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeMediumLevelILFunction(BNMediumLevelILFunction* func)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeMediumLevelILFunction"
        )]
		internal static extern void BNFreeMediumLevelILFunction(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  
			
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNOffsetWithConfidence BNGetTypeStackAdjustment(BNType* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetTypeStackAdjustment"
        )]
		internal static extern BNOffsetWithConfidence BNGetTypeStackAdjustment(
			
			// BNType* type
		    IntPtr type  
		);
	}
}
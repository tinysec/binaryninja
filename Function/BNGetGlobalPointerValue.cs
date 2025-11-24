using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRegisterValueWithConfidence BNGetGlobalPointerValue(BNBinaryView* view)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetGlobalPointerValue"
        )]
		internal static extern BNRegisterValueWithConfidence BNGetGlobalPointerValue(
			
			// BNBinaryView* view
		    IntPtr view  
		);
	}
}
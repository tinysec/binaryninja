using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetUserGlobalPointerValue(BNBinaryView* view, BNRegisterValueWithConfidence value)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetUserGlobalPointerValue"
        )]
		internal static extern void BNSetUserGlobalPointerValue(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNRegisterValueWithConfidence value
		    in BNRegisterValueWithConfidence value  
		);
	}
}
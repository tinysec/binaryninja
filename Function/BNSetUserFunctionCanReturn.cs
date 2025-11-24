using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetUserFunctionCanReturn(BNFunction* func, BNBoolWithConfidence* returns)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetUserFunctionCanReturn"
        )]
		internal static extern void BNSetUserFunctionCanReturn(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNBoolWithConfidence* returns
			in BNBoolWithConfidence returns  
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetUserFunctionPure(BNFunction* func, BNBoolWithConfidence* pure)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetUserFunctionPure"
        )]
		internal static extern void BNSetUserFunctionPure(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNBoolWithConfidence* pure
		    in BNBoolWithConfidence pure  
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetUserFunctionStackAdjustment(BNFunction* func, BNOffsetWithConfidence* stackAdjust)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetUserFunctionStackAdjustment"
        )]
		internal static extern void BNSetUserFunctionStackAdjustment(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNOffsetWithConfidence* stackAdjust
		    IntPtr stackAdjust  
			
		);
	}
}
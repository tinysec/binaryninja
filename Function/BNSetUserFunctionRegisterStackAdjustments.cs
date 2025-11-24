using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetUserFunctionRegisterStackAdjustments(BNFunction* func, BNRegisterStackAdjustment* adjustments, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetUserFunctionRegisterStackAdjustments"
        )]
		internal static extern void BNSetUserFunctionRegisterStackAdjustments(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNRegisterStackAdjustment* adjustments
		    IntPtr adjustments  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}
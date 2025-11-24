using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetAutoFunctionRegisterStackAdjustments(BNFunction* func, BNRegisterStackAdjustment* adjustments, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetAutoFunctionRegisterStackAdjustments"
        )]
		internal static extern void BNSetAutoFunctionRegisterStackAdjustments(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNRegisterStackAdjustment* adjustments
		    IntPtr adjustments  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}
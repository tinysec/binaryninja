using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRegisterStackAdjustment* BNGetFunctionRegisterStackAdjustments(BNFunction* func, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetFunctionRegisterStackAdjustments"
        )]
		internal static extern IntPtr BNGetFunctionRegisterStackAdjustments(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}
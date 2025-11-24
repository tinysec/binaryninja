using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNReanalyzeFunction(BNFunction* func, BNFunctionUpdateType type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNReanalyzeFunction"
        )]
		internal static extern void BNReanalyzeFunction(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNFunctionUpdateType type
		    FunctionUpdateType type  
		);
	}
}
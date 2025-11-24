using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNMarkUpdatesRequired(BNFunction* func, BNFunctionUpdateType type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNMarkUpdatesRequired"
        )]
		internal static extern void BNMarkUpdatesRequired(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNFunctionUpdateType type
		    FunctionUpdateType type  
			
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTransformContext** BNTransformSessionGetSelectedContexts(BNTransformSession* session, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNTransformSessionGetSelectedContexts"
        )]
		internal static extern IntPtr BNTransformSessionGetSelectedContexts(
			
			// BNTransformSession* session
		    IntPtr session  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}
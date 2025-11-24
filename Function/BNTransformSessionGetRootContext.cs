using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTransformContext* BNTransformSessionGetRootContext(BNTransformSession* session)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNTransformSessionGetRootContext"
        )]
		internal static extern IntPtr BNTransformSessionGetRootContext(
			
			// BNTransformSession* session
		    IntPtr session  
			
		);
	}
}
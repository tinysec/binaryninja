using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTransformContext* BNTransformSessionGetCurrentContext(BNTransformSession* session)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNTransformSessionGetCurrentContext"
        )]
		internal static extern IntPtr BNTransformSessionGetCurrentContext(
			
			// BNTransformSession* session
		    IntPtr session  
			
		);
	}
}
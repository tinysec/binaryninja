using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNTransformContextGetExtractionMessage(BNTransformContext* context)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNTransformContextGetExtractionMessage"
        )]
		internal static extern IntPtr BNTransformContextGetExtractionMessage(
			
			// BNTransformContext* context
		    IntPtr context  
			
		);
	}
}
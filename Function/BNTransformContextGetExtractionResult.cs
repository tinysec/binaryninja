using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTransformResult BNTransformContextGetExtractionResult(BNTransformContext* context)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNTransformContextGetExtractionResult"
        )]
		internal static extern TransformResult BNTransformContextGetExtractionResult(
			
			// BNTransformContext* context
		    IntPtr context  
		);
	}
}
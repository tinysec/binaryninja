using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNTransformContextHasAvailableFiles(BNTransformContext* context)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNTransformContextHasAvailableFiles"
        )]
		internal static extern bool BNTransformContextHasAvailableFiles(
			
			// BNTransformContext* context
		    IntPtr context  
		);
	}
}
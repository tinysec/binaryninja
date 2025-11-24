using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char** BNTransformContextGetRequestedFiles(BNTransformContext* context, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNTransformContextGetRequestedFiles"
        )]
		internal static extern IntPtr BNTransformContextGetRequestedFiles(
			
			// BNTransformContext* context
		    IntPtr context  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}
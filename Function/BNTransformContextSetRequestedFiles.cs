using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNTransformContextSetRequestedFiles(BNTransformContext* context, const char** files, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNTransformContextSetRequestedFiles"
        )]
		internal static extern void BNTransformContextSetRequestedFiles(
			
			// BNTransformContext* context
		    IntPtr context  , 
			
			// const char** files
		    string[] files  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}
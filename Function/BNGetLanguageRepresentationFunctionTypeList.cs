using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLanguageRepresentationFunctionType** BNGetLanguageRepresentationFunctionTypeList(uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLanguageRepresentationFunctionTypeList"
        )]
		internal static extern IntPtr BNGetLanguageRepresentationFunctionTypeList(
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
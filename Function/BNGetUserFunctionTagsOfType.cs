using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTag** BNGetUserFunctionTagsOfType(BNFunction* func, BNTagType* tagType, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetUserFunctionTagsOfType"
        )]
		internal static extern IntPtr BNGetUserFunctionTagsOfType(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNTagType* tagType
		    IntPtr tagType  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNRemoveAutoFunctionTagsOfType(BNFunction* func, BNTagType* tagType)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRemoveAutoFunctionTagsOfType"
        )]
		internal static extern void BNRemoveAutoFunctionTagsOfType(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNTagType* tagType
		    IntPtr tagType  
			
		);
	}
}
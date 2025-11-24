using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNRemoveUserFunctionTagsOfType(BNFunction* func, BNTagType* tagType)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRemoveUserFunctionTagsOfType"
        )]
		internal static extern void BNRemoveUserFunctionTagsOfType(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNTagType* tagType
		    IntPtr tagType  
			
		);
	}
}
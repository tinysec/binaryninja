using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeStringReferenceList(BNStringReference* strings)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeStringReferenceList"
        )]
		internal static extern void BNFreeStringReferenceList(
			
			// BNStringReference* strings
		    IntPtr strings  
		);
	}
}
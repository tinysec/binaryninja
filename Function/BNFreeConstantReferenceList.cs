using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeConstantReferenceList(BNConstantReference* refs)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeConstantReferenceList"
        )]
		internal static extern void BNFreeConstantReferenceList(
			
			// BNConstantReference* refs
		    IntPtr refs  
			
		);
	}
}
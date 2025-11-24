using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeStackVariableReferenceList(BNStackVariableReference* refs, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeStackVariableReferenceList"
        )]
		internal static extern void BNFreeStackVariableReferenceList(
			
			// BNStackVariableReference* refs
		    IntPtr refs  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}
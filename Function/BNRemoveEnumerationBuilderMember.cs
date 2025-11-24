using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNRemoveEnumerationBuilderMember(BNEnumerationBuilder* e, uint64_t idx)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNRemoveEnumerationBuilderMember"
        )]
		internal static extern void BNRemoveEnumerationBuilderMember(
			
			// BNEnumerationBuilder* e
		    IntPtr e  , 
			
			// uint64_t idx
		    ulong idx  
		);
	}
}
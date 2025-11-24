using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeIndirectBranchList(BNIndirectBranchInfo* branches)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeIndirectBranchList"
        )]
		internal static extern void BNFreeIndirectBranchList(
			
			// BNIndirectBranchInfo* branches
		    IntPtr branches  
		);
	}
}
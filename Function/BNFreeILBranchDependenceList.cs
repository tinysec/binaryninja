using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeILBranchDependenceList(BNILBranchInstructionAndDependence* branches)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeILBranchDependenceList"
        )]
		internal static extern void BNFreeILBranchDependenceList(
			
			// BNILBranchInstructionAndDependence* branches
		    IntPtr branches  
		);
	}
}
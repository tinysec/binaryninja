using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNBasicBlockAddPendingOutgoingEdge(BNBasicBlock* block, BNBranchType type, uint64_t addr, BNArchitecture* arch, bool fallThrough)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNBasicBlockAddPendingOutgoingEdge"
        )]
		internal static extern void BNBasicBlockAddPendingOutgoingEdge(
			
			// BNBasicBlock* block
		    IntPtr block  , 
			
			// BNBranchType type
		    BranchType kind  , 
			
			// uint64_t addr
		    ulong addr  , 
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// bool fallThrough
		    bool fallThrough  
		);
	}
}
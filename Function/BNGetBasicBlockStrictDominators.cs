using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNBasicBlock** BNGetBasicBlockStrictDominators(BNBasicBlock* block, uint64_t* count, bool post)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetBasicBlockStrictDominators"
        )]
		internal static extern IntPtr BNGetBasicBlockStrictDominators(
			
			// BNBasicBlock* block
		    IntPtr block  , 
			
			// uint64_t* count
		    out ulong count  , 
			
			// bool post
		    bool post  
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNBasicBlock* BNGetBasicBlockImmediateDominator(BNBasicBlock* block, bool post)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetBasicBlockImmediateDominator"
        )]
		internal static extern IntPtr BNGetBasicBlockImmediateDominator(
			
			// BNBasicBlock* block
		    IntPtr block  , 
			
			// bool post
		    bool post  
		);
	}
}
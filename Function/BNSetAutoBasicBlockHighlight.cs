using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetAutoBasicBlockHighlight(BNBasicBlock* block, BNHighlightColor color)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetAutoBasicBlockHighlight"
        )]
		internal static extern void BNSetAutoBasicBlockHighlight(
			
			// BNBasicBlock* block
		    IntPtr block  , 
			
			// BNHighlightColor color
			BNHighlightColor color  
		);
	}
}
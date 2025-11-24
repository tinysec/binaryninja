using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNBasicBlockSetHasInvalidInstructions(BNBasicBlock* block, bool value)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNBasicBlockSetHasInvalidInstructions"
        )]
		internal static extern void BNBasicBlockSetHasInvalidInstructions(
			
			// BNBasicBlock* block
		    IntPtr block  , 
			
			// bool _value
		    bool _value  
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNBasicBlockSetUndeterminedOutgoingEdges(BNBasicBlock* block, bool value)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNBasicBlockSetUndeterminedOutgoingEdges"
        )]
		internal static extern void BNBasicBlockSetUndeterminedOutgoingEdges(
			
			// BNBasicBlock* block
		    IntPtr block  , 
			
			// bool _value
		    bool _value  
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNBasicBlockSetCanExit(BNBasicBlock* block, bool value)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNBasicBlockSetCanExit"
        )]
		internal static extern void BNBasicBlockSetCanExit(
			
			// BNBasicBlock* block
		    IntPtr block  , 
			
			// bool _value
		    bool _value  
		);
	}
}
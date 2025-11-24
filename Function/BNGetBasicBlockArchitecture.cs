using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNArchitecture* BNGetBasicBlockArchitecture(BNBasicBlock* block)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetBasicBlockArchitecture"
        )]
		internal static extern IntPtr BNGetBasicBlockArchitecture(
			
			// BNBasicBlock* block
		    IntPtr block  
			
		);
	}
}
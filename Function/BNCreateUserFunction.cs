using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNFunction* BNCreateUserFunction(BNBinaryView* view, BNPlatform* platform, uint64_t addr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateUserFunction"
        )]
		internal static extern IntPtr BNCreateUserFunction(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNPlatform* platform
		    IntPtr platform  , 
			
			// uint64_t addr
		    ulong addr  
		);
	}
}
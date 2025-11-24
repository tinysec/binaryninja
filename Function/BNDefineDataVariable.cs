using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNDefineDataVariable(BNBinaryView* view, uint64_t addr, BNTypeWithConfidence* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNDefineDataVariable"
        )]
		internal static extern void BNDefineDataVariable(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// uint64_t addr
		    ulong addr  , 
			
			// BNTypeWithConfidence* type
		    in BNTypeWithConfidence type  
		);
	}
}
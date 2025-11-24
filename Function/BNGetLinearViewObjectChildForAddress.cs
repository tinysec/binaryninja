using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLinearViewObject* BNGetLinearViewObjectChildForAddress(BNLinearViewObject* parent, uint64_t addr)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLinearViewObjectChildForAddress"
        )]
		internal static extern IntPtr BNGetLinearViewObjectChildForAddress(
			
			// BNLinearViewObject* parent
		    IntPtr parent  , 
			
			// uint64_t addr
		    ulong addr  
		);
	}
}
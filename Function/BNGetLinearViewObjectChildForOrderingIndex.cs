using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLinearViewObject* BNGetLinearViewObjectChildForOrderingIndex(BNLinearViewObject* parent, uint64_t idx)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLinearViewObjectChildForOrderingIndex"
        )]
		internal static extern IntPtr BNGetLinearViewObjectChildForOrderingIndex(
			
			// BNLinearViewObject* parent
		    IntPtr parent  , 
			
			// uint64_t idx
		    ulong idx  
		);
	}
}
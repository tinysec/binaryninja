using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetLinearViewObjectOrderingIndexTotal(BNLinearViewObject* obj)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLinearViewObjectOrderingIndexTotal"
        )]
		internal static extern ulong BNGetLinearViewObjectOrderingIndexTotal(
			
			// BNLinearViewObject* obj
		    IntPtr obj  
		);
	}
}
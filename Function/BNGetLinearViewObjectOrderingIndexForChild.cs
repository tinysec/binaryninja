using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetLinearViewObjectOrderingIndexForChild(BNLinearViewObject* parent, BNLinearViewObject* child)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLinearViewObjectOrderingIndexForChild"
        )]
		internal static extern ulong BNGetLinearViewObjectOrderingIndexForChild(
			
			// BNLinearViewObject* parent
		    IntPtr parent  , 
			
			// BNLinearViewObject* child
		    IntPtr child  
		);
	}
}
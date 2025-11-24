using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLinearViewObject* BNNewLinearViewObjectReference(BNLinearViewObject* obj)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNNewLinearViewObjectReference"
        )]
		internal static extern IntPtr BNNewLinearViewObjectReference(
			
			// BNLinearViewObject* obj
		    IntPtr obj  
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLinearViewObject* BNGetLastLinearViewObjectChild(BNLinearViewObject* obj)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLastLinearViewObjectChild"
        )]
		internal static extern IntPtr BNGetLastLinearViewObjectChild(
			
			// BNLinearViewObject* obj
		    IntPtr obj  
		);
	}
}
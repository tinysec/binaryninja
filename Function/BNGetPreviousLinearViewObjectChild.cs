using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLinearViewObject* BNGetPreviousLinearViewObjectChild(BNLinearViewObject* parent, BNLinearViewObject* child)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetPreviousLinearViewObjectChild"
        )]
		internal static extern IntPtr BNGetPreviousLinearViewObjectChild(
			
			// BNLinearViewObject* parent
		    IntPtr parent  , 
			
			// BNLinearViewObject* child
		    IntPtr child  
		);
	}
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLinearViewObject* BNGetNextLinearViewObjectChild(BNLinearViewObject* parent, BNLinearViewObject* child)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetNextLinearViewObjectChild"
        )]
		internal static extern IntPtr BNGetNextLinearViewObjectChild(
			
			// BNLinearViewObject* parent
		    IntPtr parent  , 
			
			// BNLinearViewObject* child
		    IntPtr child  
		);
	}
}
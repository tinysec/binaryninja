using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// int32_t BNCompareLinearViewObjectChildren(BNLinearViewObject* obj, BNLinearViewObject* a, BNLinearViewObject* b)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCompareLinearViewObjectChildren"
        )]
		internal static extern int BNCompareLinearViewObjectChildren(
			
			// BNLinearViewObject* obj
		    IntPtr obj  , 
			
			// BNLinearViewObject* a
		    IntPtr a  , 
			
			// BNLinearViewObject* b
		    IntPtr b  
		);
	}
}
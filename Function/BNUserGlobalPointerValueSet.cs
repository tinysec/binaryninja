using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNUserGlobalPointerValueSet(BNBinaryView* view)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNUserGlobalPointerValueSet"
        )]
		internal static extern bool BNUserGlobalPointerValueSet(
			
			// BNBinaryView* view
		    IntPtr view  
		);
	}
}
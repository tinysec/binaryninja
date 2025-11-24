using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNComponentsNotEqual(BNComponent* a, BNComponent* b)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNComponentsNotEqual"
        )]
		internal static extern bool BNComponentsNotEqual(
			
			// BNComponent* a
		    IntPtr a  , 
			
			// BNComponent* b
		    IntPtr b  
		);
	}
}
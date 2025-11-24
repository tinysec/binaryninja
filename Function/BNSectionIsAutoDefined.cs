using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNSectionIsAutoDefined(BNSection* section)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSectionIsAutoDefined"
        )]
		internal static extern bool BNSectionIsAutoDefined(
			
			// BNSection* section
		    IntPtr section  
			
		);
	}
}
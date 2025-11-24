using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNSectionSemantics BNSectionGetSemantics(BNSection* section)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSectionGetSemantics"
        )]
		internal static extern SectionSemantics BNSectionGetSemantics(
			
			// BNSection* section
		    IntPtr section  
			
		);
	}
}
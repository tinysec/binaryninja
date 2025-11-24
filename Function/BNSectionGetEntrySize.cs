using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNSectionGetEntrySize(BNSection* section)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSectionGetEntrySize"
        )]
		internal static extern ulong BNSectionGetEntrySize(
			
			// BNSection* section
		    IntPtr section  
			
		);
	}
}
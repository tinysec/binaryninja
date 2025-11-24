using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNRelocationGetReloc(BNRelocation* reloc)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRelocationGetReloc"
        )]
		internal static extern ulong BNRelocationGetReloc(
			
			// BNRelocation* reloc
		    IntPtr reloc  
			
		);
	}
}
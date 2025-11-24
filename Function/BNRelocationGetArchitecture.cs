using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNArchitecture* BNRelocationGetArchitecture(BNRelocation* reloc)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRelocationGetArchitecture"
        )]
		internal static extern IntPtr BNRelocationGetArchitecture(
			
			// BNRelocation* reloc
		    IntPtr reloc  
			
		);
	}
}